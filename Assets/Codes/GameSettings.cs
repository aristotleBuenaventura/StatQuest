using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameSettings : MonoBehaviour
{
    public GameObject Settings;

    void Start()
    {
        Settings.SetActive(false);
    }

    public void openSettings()
    {
        Settings.SetActive(true);
    }

    public void closeSettings()
    {
        Settings.SetActive(false);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
