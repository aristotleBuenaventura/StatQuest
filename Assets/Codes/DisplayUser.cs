using UnityEngine;
using TMPro;

public class DisplayUser : MonoBehaviour
{
    public TextMeshProUGUI userIDText; // Reference to a TextMeshProUGUI component
    public GameObject PlayerInfoGroup;
    public GameObject SubMenu;
    public GameObject logo;
    public GameObject SuccessCanvasFromEditUserId;
    public GameObject PlayerDetails;

    void Start()
    {
        PlayerInfoGroup.SetActive(false);
        SubMenu.SetActive(true);
        // Display the userID when the scene starts
        UpdateUserIDText();

    }

    void OnEnable()
    {
        // Update the userID text when the object becomes enabled (this handles any changes after the scene is loaded)
        UpdateUserIDText();
    }

    public void UpdateUserIDText()
    {
        // Ensure the userID is up to date
        if (userIDText != null)
        {
            userIDText.text = "Hi Player " + UserData.userID + "!";
        }
        else
        {
            Debug.LogError("TextMeshProUGUI reference is not assigned in the inspector.");
        }
    }

    public void openPlayerInfo()
    {
        PlayerInfoGroup.SetActive(true);
        SubMenu.SetActive(false);
        logo.SetActive(false);
    }

    public void back()
    {
        PlayerInfoGroup.SetActive(false);
        SubMenu.SetActive(true);
        logo.SetActive(true);
        SuccessCanvasFromEditUserId.SetActive(false);
        PlayerDetails.SetActive(true);
    }
}
