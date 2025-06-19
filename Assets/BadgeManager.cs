using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;

public class BadgeManager : MonoBehaviour
{
    public enum BadgeType { True, False }
    public string sceneName; // Example: "Scene1"


    private DatabaseReference dbRef;

    void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }



    public void SaveBadge(BadgeType badge)
    {
        string userID = UserData.userID;
        if (string.IsNullOrEmpty(userID)) return;

        dbRef.Child("users").Child(userID).Child("badges").Child(sceneName).SetValueAsync(badge.ToString())
            .ContinueWithOnMainThread(task =>
            {
                if (task.IsCompleted)
                {
                    Debug.Log($"Badge '{badge}' saved for {sceneName}");
                }
                else
                {
                    Debug.LogError($"Failed to save badge: {task.Exception}");
                }
            });
    }
}
