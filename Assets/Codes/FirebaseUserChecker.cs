using Firebase.Database;
using Firebase.Extensions;
using TMPro;
using UnityEngine;

public class FirebaseUserChecker : MonoBehaviour
{
    private DatabaseReference dbRef;
    public MainMenu menu;
    public GameObject NoUserFound;

    // Reference to the userID input field
    public TMP_InputField userIDInputField;

    void Start()
    {
        CloseNoUserFound();
    }

    private void Awake()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void CheckUserIDFromInputField()
    {
        if (userIDInputField == null)
        {
            Debug.LogError("userIDInputField is not assigned in the Inspector!");
            return;
        }

        string inputUserID = userIDInputField.text;

        if (string.IsNullOrEmpty(inputUserID))
        {
            Debug.LogError("UserID input is empty!");
            return;
        }

        CheckUserID(inputUserID, isValid =>
        {
            if (isValid)
            {
                // Save the userID in UserData class and PlayerPrefs
                UserData.userID = inputUserID;
                PlayerPrefs.SetString("userID", inputUserID);
                PlayerPrefs.Save();

                // Navigate to the SubMenu
                userIDInputField.text = "";
                menu.SubMenu();
                Debug.Log("LOGIN");
            }
            else
            {
                NoUserFound.SetActive(true);
                Debug.Log("FAILED");
            }
        });
    }

    public void CheckUserID(string inputUserID, System.Action<bool> callback)
    {
        dbRef.Child("users").Child(inputUserID).GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && task.Result.Exists)
            {
                Debug.Log("UserID exists in Firebase: " + inputUserID);
                callback(true);
            }
            else
            {
                Debug.Log("UserID does not exist in Firebase: " + inputUserID);
                callback(false);
            }
        });
    }

    public void CloseNoUserFound()
    {
        NoUserFound.SetActive(false);
        userIDInputField.text = "";
    }
}
