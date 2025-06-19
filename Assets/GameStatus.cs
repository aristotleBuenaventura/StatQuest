using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    private DatabaseReference dbRef;
    private string userID;
    public Slider progress;
    //items
    public GameObject item1, item2, item3, item4, item5, item6, item7, item8, item9;



    void Start()
    {
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item6.SetActive(false);
        item7.SetActive(false);
        item8.SetActive(false);
        item9.SetActive(false);

        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                dbRef = FirebaseDatabase.DefaultInstance.RootReference;
                userID = PlayerPrefs.GetString("userID", "");

                if (!string.IsNullOrEmpty(userID))
                {
                    LoadLevelFromFirebase(userID);
                }
                else
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

    void LoadLevelFromFirebase(string userID)
    {
        dbRef.Child("users").Child(userID).Child("level").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Firebase data retrieval failed: " + task.Exception);
                return;
            }

            if (task.IsCompleted && task.Result.Exists)
            {
                if (int.TryParse(task.Result.Value.ToString(), out int level))
                {
                    DisplayLevel(level);
                }
                else
                {
                    Debug.LogError("Invalid level data format in Firebase.");
                }
            }
            else
            {
                Debug.LogWarning("Level data not found for user: " + userID);
            }
        });
    }

    void DisplayLevel(int level)
    {
        switch (level)
        {
            case 0:
                break;
            case 1:
                progress.value = 0.11f;
                item1.SetActive(true);
                break;
            case 2:
                progress.value = 0.22f;
                item1.SetActive(true);
                item2.SetActive(true);
                break;
            case 3:
                progress.value = 0.33f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                break;
            case 4:
                progress.value = 0.44f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                break;
            case 5:
                progress.value = 0.55f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                break;
            case 6:
                progress.value = 0.66f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                break;
            case 7:
                progress.value = 0.77f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                item7.SetActive(true);
                break;
            case 8:
                progress.value = 0.88f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                item7.SetActive(true);
                item8.SetActive(true);
                break;
            case 9:
                progress.value = 1f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                item7.SetActive(true);
                item8.SetActive(true);
                item9.SetActive(true);
                break;
            case 999:
                progress.value = 1f;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                item7.SetActive(true);
                item8.SetActive(true);
                item9.SetActive(true);
                break;
            default:
                Debug.Log("Level: " + level);
                break;
        }
    }
}
