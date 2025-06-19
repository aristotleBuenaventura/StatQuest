using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;
using System.Collections.Generic;

public class BadgeDisplayManager : MonoBehaviour
{
    private DatabaseReference dbRef;
    private readonly string[] scenes = { "Scene1", "Scene2", "Scene3", "Scene4", "Scene5", "Scene6", "Scene7", "Scene8", "Scene9" };
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9;
    public GameObject s1n, s2n, s3n, s4n, s5n, s6n, s7n, s8n, s9n;

    void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);

        s1n.SetActive(false);
        s2n.SetActive(false);
        s3n.SetActive(false);
        s4n.SetActive(false);
        s5n.SetActive(false);
        s6n.SetActive(false);
        s7n.SetActive(false);
        s8n.SetActive(false);
        s9n.SetActive(false);

        LoadBadges();
    }

    void LoadBadges()
    {
        string userID = UserData.userID;
        if (string.IsNullOrEmpty(userID)) return;

        dbRef.Child("users").Child(userID).Child("badges").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                Dictionary<string, string> badgeData = new Dictionary<string, string>();

                foreach (string scene in scenes)
                {
                    if (snapshot.HasChild(scene))
                    {
                        badgeData[scene] = snapshot.Child(scene).Value.ToString();
                    }
                    else
                    {
                        badgeData[scene] = "None";
                    }
                }

                DisplayBadges(badgeData);
            }
            else
            {
                Debug.LogError("Failed to load badges: " + task.Exception);
            }
        });
    }

    void DisplayBadges(Dictionary<string, string> badges)
    {
        string display = "";
        foreach (var badge in badges)
        {
            display += $"{badge.Key}: {badge.Value}\n";

            if (badge.Key == "Scene1" && badge.Value == "True")
            {
                s1.SetActive(true);
                s1n.SetActive(false);

                Debug.Log("Scene1 badge is achieved!");
                // Add your logic here, like showing the badge in UI
            }
            else if (badge.Key == "Scene2" && badge.Value == "True")
            {
                s2.SetActive(true);
                s2n.SetActive(false);
                Debug.Log("Scene2 badge is achieved!");
            }
            else if (badge.Key == "Scene3" && badge.Value == "True")
            {
                s3.SetActive(true);
                s3n.SetActive(false);
                Debug.Log("Scene3 badge is achieved!");
            }
            else if (badge.Key == "Scene4" && badge.Value == "True")
            {
                s4.SetActive(true);
                s4n.SetActive(false);
                Debug.Log("Scene4 badge is achieved!");
            }
            else if (badge.Key == "Scene5" && badge.Value == "True")
            {
                s5.SetActive(true);
                s5n.SetActive(false);
                Debug.Log("Scene5 badge is achieved!");
            }
            else if (badge.Key == "Scene6" && badge.Value == "True")
            {
                s6.SetActive(true);
                s6n.SetActive(false);
                Debug.Log("Scene6 badge is achieved!");
            }
            else if (badge.Key == "Scene7" && badge.Value == "True")
            {
                s7.SetActive(true);
                s7n.SetActive(false);
                Debug.Log("Scene7 badge is achieved!");
            }
            else if (badge.Key == "Scene8" && badge.Value == "True")
            {
                s8.SetActive(true);
                s8n.SetActive(false);
                Debug.Log("Scene8 badge is achieved!");
            }
            else if (badge.Key == "Scene9" && badge.Value == "True")
            {
                s9.SetActive(true);
                s9n.SetActive(false);
                Debug.Log("Scene9 badge is achieved!");
            }
            else if (badge.Key == "Scene1" && badge.Value == "False")
            {
                s1.SetActive(false);
                s1n.SetActive(true);
                Debug.Log("Scene1 badge is achieved!");
                // Add your logic here, like showing the badge in UI
            }
            else if (badge.Key == "Scene2" && badge.Value == "False")
            {
                s2.SetActive(false);
                s2n.SetActive(true);
                Debug.Log("Scene2 badge is achieved!");
            }
            else if (badge.Key == "Scene3" && badge.Value == "False")
            {
                s3.SetActive(false);
                s3n.SetActive(true);
                Debug.Log("Scene3 badge is achieved!");
            }
            else if (badge.Key == "Scene4" && badge.Value == "False")
            {
                s4.SetActive(false);
                s4n.SetActive(true);
                Debug.Log("Scene4 badge is achieved!");
            }
            else if (badge.Key == "Scene5" && badge.Value == "False")
            {
                s5.SetActive(false);
                s5n.SetActive(true);
                Debug.Log("Scene5 badge is achieved!");
            }
            else if (badge.Key == "Scene6" && badge.Value == "False")
            {
                s6.SetActive(false);
                s6n.SetActive(true);
                Debug.Log("Scene6 badge is achieved!");
            }
            else if (badge.Key == "Scene7" && badge.Value == "False")
            {
                s7.SetActive(false);
                s7n.SetActive(true);
                Debug.Log("Scene7 badge is achieved!");
            }
            else if (badge.Key == "Scene8" && badge.Value == "False")
            {
                s8.SetActive(false);
                s8n.SetActive(true);
                Debug.Log("Scene8 badge is achieved!");
            }
            else if (badge.Key == "Scene9" && badge.Value == "False")
            {
                s9.SetActive(false);
                s9n.SetActive(true);
                Debug.Log("Scene9 badge is achieved!");
            }
        }

        Debug.Log(display); // Optional: Still logs all badge info
    }

}
