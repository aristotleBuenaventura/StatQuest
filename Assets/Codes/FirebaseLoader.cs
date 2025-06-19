using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using TMPro;

public class FirebaseLoader : MonoBehaviour
{
    private DatabaseReference dbRef;
    public TMP_Text userIDText;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                dbRef = FirebaseDatabase.DefaultInstance.RootReference;

                string userID = PlayerPrefs.GetString("userID", "");

                if (!string.IsNullOrEmpty(userID))
                {
                    LoadUserData(userID);
                }
                else
                {
                    Debug.LogWarning("No userID found in PlayerPrefs.");
                }
            }
            else
            {
                Debug.LogError("Firebase dependencies not resolved: " + task.Result);
            }
        });
    }

    void LoadUserData(string userID)
    {
        dbRef.Child("users").Child(userID).GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && task.Result.Exists)
            {
                Debug.Log("User ID: " + userID);

                if (userIDText != null)
                {
                    userIDText.text = "User ID: " + userID;
                }
            }
            else
            {
                Debug.LogWarning("User data not found in Firebase.");
            }
        });
    }
}
