using UnityEngine;
using TMPro;

public class userIDupdater : MonoBehaviour
{
    public TMP_InputField userIDInputField;

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
