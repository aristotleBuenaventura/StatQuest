using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public string retrySceneName = "Scene1"; // Set in Inspector
    public string mapScene = "Game"; // Set in Inspector


    public static GameOverManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Yes()
    {
        Time.timeScale = 1f; // Resume game
        SceneManager.LoadScene(retrySceneName); // Load retry scene (set in Inspector)
    }

    public void No()
    {
        Time.timeScale = 1f; // Resume game
        SceneManager.LoadScene(mapScene); // Load main menu (set in Inspector)
    }
}
