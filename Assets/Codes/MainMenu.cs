using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using TMPro;
using System;
using System.Collections;

[Serializable]
public class dataToSave
{
    public string userName;
    public int level = 0; // Default level set to 0
}

public class MainMenu : MonoBehaviour
{
    public TMP_InputField userIDInputField;
    public GameObject MainMenuButtons;
    public GameObject SubMenuButtons;
    public GameObject logo;
    public GameObject ReturningPlayerField;
    public GameObject Successful;
    public GameObject UserDetails;
    public GameObject GameStatus;
    public GameObject itemCollection, badgeCollection;
    public DisplayUser user;
    public dataToSave dts = new dataToSave(); // Initialize dts to avoid null reference
    public GameObject tutorial, WhatIsStatQuest, HowToUseControls, GameElements, HowQuestsWorks1, HowQuestsWorks2, HowQuestsWorks3, HowQuestsWorks4, HowQuestsWorks5, BadgeManager;
    private DatabaseReference dbRef;

    public void itemCollectionShow()
    {
        itemCollection.SetActive(true);
        badgeCollection.SetActive(false);
    }

    public void badgeCollectionShow()
    {
        itemCollection.SetActive(false);
        badgeCollection.SetActive(true);
    }

    public void tutorialCanvas()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(true);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void FirstTutorial()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(true);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void SecondTutorial()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(true);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void ThirdTutorial()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(true);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void LastTutorial()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(true);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void LastTutorial2()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(true);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void LastTutorial3()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(true);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);
    }

    public void LastTutorial4()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(true);
        HowQuestsWorks5.SetActive(false);
    }

    public void LastTutorial5()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(true);
    }

    void Start()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(true);
        logo.SetActive(true);
        Successful.SetActive(false);
        GameStatus.SetActive(false);
        tutorial.SetActive(false);
        WhatIsStatQuest.SetActive(false);
        HowToUseControls.SetActive(false);
        GameElements.SetActive(false);
        HowQuestsWorks1.SetActive(false);
        HowQuestsWorks2.SetActive(false);
        HowQuestsWorks3.SetActive(false);
        HowQuestsWorks4.SetActive(false);
        HowQuestsWorks5.SetActive(false);

        InitializeFirebase();

        // Initialize userID
        if (PlayerPrefs.HasKey("userID"))
        {
            UserData.userID = PlayerPrefs.GetString("userID");
            Debug.Log("Loaded existing userID: " + UserData.userID);
        }
        else
        {
            UserData.userID = GenerateUniqueUserID();
            PlayerPrefs.SetString("userID", UserData.userID);
            PlayerPrefs.Save();
            Debug.Log("Generated and saved new userID: " + UserData.userID);
        }
    }

    private string GenerateUniqueUserID()
    {
        System.Random random = new System.Random();
        return random.Next(10000, 99999).ToString();
    }

    private void InitializeFirebase()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                dbRef = FirebaseDatabase.DefaultInstance.RootReference;
                Debug.Log("Firebase Database Initialized.");
            }
            else
            {
                Debug.LogError("Could not resolve Firebase dependencies: " + task.Result);
            }
        });
    }

    public void SubMenu()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(true);
        MainMenuButtons.SetActive(false);
        GameStatus.SetActive(false);
        logo.SetActive(true);
        tutorial.SetActive(false);
    }



    public void StartButton()
    {
        if (!PlayerPrefs.HasKey("userID"))
        {
            UserData.userID = GenerateUniqueUserID();
            PlayerPrefs.SetString("userID", UserData.userID);
            PlayerPrefs.Save();
        }

        SubMenuButtons.SetActive(true);
        MainMenuButtons.SetActive(false);
        BadgeManager.SetActive(true);

        // Check if user exists in Firebase
        dbRef.Child("users").Child(UserData.userID).GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                if (snapshot.Exists)
                {
                    // User already exists, retrieve their data
                    string json = snapshot.GetRawJsonValue();
                    dts = JsonUtility.FromJson<dataToSave>(json);
                    Debug.Log("Existing user found: " + dts.userName + " with level " + dts.level);
                }
                else
                {
                    // New user, set level to 0
                    dts.userName = "New Player"; // Modify as needed
                    dts.level = 0;

                    string json = JsonUtility.ToJson(dts);
                    dbRef.Child("users").Child(UserData.userID).SetRawJsonValueAsync(json).ContinueWithOnMainThread(saveTask =>
                    {
                        if (saveTask.IsCompleted)
                        {
                            Debug.Log("New user data saved successfully with level 0!");
                        }
                        else
                        {
                            Debug.LogError("Failed to save new user data: " + saveTask.Exception);
                        }
                    });
                }
            }
            else
            {
                Debug.LogError("Failed to check user existence: " + task.Exception);
            }
        });
    }

    public void ReturningPlayerButton()
    {
        ReturningPlayerField.SetActive(true);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        logo.SetActive(false);
        GameStatus.SetActive(false);
    }

    public void GameStatusOpen()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(false);
        logo.SetActive(false);
        GameStatus.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButtonFromGameStatus()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(true);
        MainMenuButtons.SetActive(false);
        logo.SetActive(true);
        GameStatus.SetActive(false);
    }

    public void BackButton()
    {
        ReturningPlayerField.SetActive(false);
        SubMenuButtons.SetActive(false);
        MainMenuButtons.SetActive(true);
        logo.SetActive(true);
        GameStatus.SetActive(false);
    }

    public void EditButtonPressed()
    {
        string newUserID = userIDInputField.text; // Get the updated userID from the InputField

        if (string.IsNullOrEmpty(newUserID))
        {
            Debug.LogWarning("User ID cannot be empty.");
            return; // Exit if the new userID is empty
        }

        UpdateFirebaseUserID(UserData.userID, newUserID);

        UserData.userID = newUserID;
        Debug.Log("Updated UserID: " + UserData.userID);
    }

    private void UpdateFirebaseUserID(string oldUserID, string newUserID)
    {
        if (dbRef != null)
        {
            dbRef.Child("users").Child(oldUserID).GetValueAsync().ContinueWithOnMainThread(task =>
            {
                if (task.IsCompleted && task.Result.Exists)
                {
                    DataSnapshot snapshot = task.Result;
                    string json = snapshot.GetRawJsonValue();

                    dbRef.Child("users").Child(newUserID).SetRawJsonValueAsync(json).ContinueWithOnMainThread(saveTask =>
                    {
                        if (saveTask.IsCompleted)
                        {
                            Debug.Log("Data copied successfully to the new document!");
                            dbRef.Child("users").Child(oldUserID).RemoveValueAsync().ContinueWithOnMainThread(removeTask =>
                            {
                                if (removeTask.IsCompleted)
                                {
                                    Debug.Log("Old document removed successfully!");
                                    Successful.SetActive(true);
                                    UserDetails.SetActive(false);
                                    user.UpdateUserIDText();
                                }
                                else
                                {
                                    Debug.LogError("Failed to remove old document: " + removeTask.Exception);
                                }
                            });
                        }
                        else
                        {
                            Debug.LogError("Failed to save new document: " + saveTask.Exception);
                        }
                    });
                }
                else
                {
                    Debug.LogError("Failed to find the old document or no data found.");
                }
            });
        }
        else
        {
            Debug.LogError("Firebase Database reference not set.");
        }
    }

    void OnEnable()
    {
        UpdateUserIDText();
    }

    public void UpdateUserIDText()
    {
        if (userIDInputField != null)
        {
            userIDInputField.text = UserData.userID;
        }
        else
        {
            Debug.LogError("TextMeshProUGUI reference is not assigned.");
        }
    }
}
