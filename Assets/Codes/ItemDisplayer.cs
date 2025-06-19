using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class ItemDisplayer : MonoBehaviour
{
    private DatabaseReference dbRef;
    private string userID;
    public DialogueDisplayMap map;
    // Barrier
    public GameObject barrier1, barrier2, barrier3, barrier4, barrier5, barrier6, barrier7, barrier8, barrier9;

    // portal
    public GameObject portal1, portal2, portal3, portal4, portal5, portal6, portal7, portal8, portal9;

    //items
    public GameObject item1, item2, item3, item4, item5, item6, item7, item8, item9;

    //colliders
    public GameObject collider1, collider2, collider3, collider4, collider5, collider6, collider7, collider8, collider9;

    void Start()
    {
        barrier1.SetActive(true);
        barrier2.SetActive(true);
        barrier3.SetActive(true);
        barrier4.SetActive(true);
        barrier5.SetActive(true);
        barrier6.SetActive(true);
        barrier7.SetActive(true);
        barrier8.SetActive(true);
        barrier9.SetActive(true);
        portal1.SetActive(false);
        portal2.SetActive(false);
        portal3.SetActive(false);
        portal4.SetActive(false);
        portal5.SetActive(false);
        portal6.SetActive(false);
        portal7.SetActive(false);
        portal8.SetActive(false);
        portal9.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item6.SetActive(false);
        item7.SetActive(false);
        item8.SetActive(false);
        item9.SetActive(false);
        collider1.SetActive(false);
        collider2.SetActive(false);
        collider3.SetActive(false);
        collider4.SetActive(false);
        collider5.SetActive(false);
        collider6.SetActive(false);
        collider7.SetActive(false);
        collider8.SetActive(false);
        collider9.SetActive(false);

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
                barrier1.SetActive(false);
                item1.SetActive(true);
                collider1.SetActive(true);
                break;
            case 1:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(true);
                portal1.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(true);
                break;
            case 2:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(true);
                break;
            case 3:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(true);
                break;
            case 4:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(true);
                break;
            case 5:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(false);
                item6.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                portal5.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(false);
                collider6.SetActive(true);
                break;
            case 6:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                barrier7.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(false);
                item6.SetActive(false);
                item7.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                portal5.SetActive(true);
                portal6.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(false);
                collider6.SetActive(false);
                collider7.SetActive(true);
                break;
            case 7:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                barrier7.SetActive(false);
                barrier8.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(false);
                item6.SetActive(false);
                item7.SetActive(false);
                item8.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                portal5.SetActive(true);
                portal6.SetActive(true);
                portal7.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(false);
                collider6.SetActive(false);
                collider7.SetActive(false);
                collider8.SetActive(true);
                break;
            case 8:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                barrier7.SetActive(false);
                barrier8.SetActive(false);
                barrier9.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(false);
                item6.SetActive(false);
                item7.SetActive(false);
                item8.SetActive(false);
                item9.SetActive(true);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                portal5.SetActive(true);
                portal6.SetActive(true);
                portal7.SetActive(true);
                portal8.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(false);
                collider6.SetActive(false);
                collider7.SetActive(false);
                collider8.SetActive(false);
                collider9.SetActive(true);
                break;
            case 9:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                barrier7.SetActive(false);
                barrier8.SetActive(false);
                barrier9.SetActive(false);
                item1.SetActive(false);
                item2.SetActive(false);
                item3.SetActive(false);
                item4.SetActive(false);
                item5.SetActive(false);
                item6.SetActive(false);
                item7.SetActive(false);
                item8.SetActive(false);
                item9.SetActive(false);
                portal1.SetActive(true);
                portal2.SetActive(true);
                portal3.SetActive(true);
                portal4.SetActive(true);
                portal5.SetActive(true);
                portal6.SetActive(true);
                portal7.SetActive(true);
                portal8.SetActive(true);
                portal9.SetActive(true);
                collider1.SetActive(false);
                collider2.SetActive(false);
                collider3.SetActive(false);
                collider4.SetActive(false);
                collider5.SetActive(false);
                collider6.SetActive(false);
                collider7.SetActive(false);
                collider8.SetActive(false);
                collider9.SetActive(false);
                break;
            case 999:
                barrier1.SetActive(false);
                barrier2.SetActive(false);
                barrier3.SetActive(false);
                barrier4.SetActive(false);
                barrier5.SetActive(false);
                barrier6.SetActive(false);
                barrier7.SetActive(false);
                barrier8.SetActive(false);
                barrier9.SetActive(false);
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                item4.SetActive(true);
                item5.SetActive(true);
                item6.SetActive(true);
                item7.SetActive(true);
                item8.SetActive(true);
                item9.SetActive(true);
                portal1.SetActive(false);
                portal2.SetActive(false);
                portal3.SetActive(false);
                portal4.SetActive(false);
                portal5.SetActive(false);
                portal6.SetActive(false);
                portal7.SetActive(false);
                portal8.SetActive(false);
                portal9.SetActive(false);
                collider1.SetActive(true);
                collider2.SetActive(true);
                collider3.SetActive(true);
                collider4.SetActive(true);
                collider5.SetActive(true);
                collider6.SetActive(true);
                collider7.SetActive(true);
                collider8.SetActive(true);
                collider9.SetActive(true);
                break;
            default:
                Debug.Log("Level: " + level);
                break;
        }
    }
}
