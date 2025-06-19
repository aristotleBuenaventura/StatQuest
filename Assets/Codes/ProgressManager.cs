using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class ProgressManager : MonoBehaviour
{
    private DatabaseReference dbRef;
    private string userID;
    public int level;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                dbRef = FirebaseDatabase.DefaultInstance.RootReference;
                userID = PlayerPrefs.GetString("userID", "");

                if (string.IsNullOrEmpty(userID))
                {
                    Debug.LogError("No userID found in PlayerPrefs.");
                }
            }
            else
            {
                Debug.LogError("Firebase dependencies not resolved: " + task.Result);
            }
        });
    }

    public void IncrementLevel()
    {
        if (string.IsNullOrEmpty(userID)) return;

        dbRef.Child("users").Child(userID).Child("level").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && task.Result.Exists)
            {
                int currentLevel = int.Parse(task.Result.Value.ToString());
                if (level > currentLevel)
                {
                    dbRef.Child("users").Child(userID).Child("level").SetValueAsync(level).ContinueWithOnMainThread(saveTask =>
                    {
                        if (saveTask.IsCompleted)
                        {
                            Debug.Log("Level updated to: " + level);
                        }
                        else
                        {
                            Debug.LogError("Failed to update level: " + saveTask.Exception);
                        }
                    });
                }
            }
            else
            {
                Debug.Log("No level data found, setting level to 1.");
                dbRef.Child("users").Child(userID).Child("level").SetValueAsync(level);
            }
        });
    }
}
