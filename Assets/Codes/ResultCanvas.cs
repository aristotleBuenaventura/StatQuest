using UnityEngine;
using TMPro; // Import TextMeshPro namespace
using UnityEngine.SceneManagement; // Import SceneManagement namespace

public class ResultCanvas : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assign this in the Inspector
    public ScoreManager score;

    public TextMeshProUGUI timerText; // Assign this in the Inspector
    public TimerDisplay time;

    public string retryScene;

    public GameObject mainbg, resultbg;

    void Start()
    {
        mainbg.SetActive(true);
        resultbg.SetActive(false);
    }
    
    void Update()
    {
        UpdateScore(); // Call this method to update the score initially
        UpdateTime();  // Update time display as well
    }

    public void UpdateScore()
    {
        if (scoreText != null && score != null)
        {
            int finalScore = score.GetScore(); // Get the score from ScoreManager
            scoreText.text = finalScore.ToString(); // Update text properly
        }
        else
        {
            Debug.LogError("ScoreText or ScoreManager is not assigned in ResultCanvas!");
        }
    }

    public void UpdateTime()
    {
        if (timerText != null && time != null)
        {
            string finalTime = time.GetTimerText(); // Get the time from TimerDisplay
            timerText.text = finalTime; // Update text properly
        }
        else
        {
            Debug.LogError("TimerText or TimerDisplay is not assigned in ResultCanvas!");
        }
    }

    // Load the main menu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu"); // Replace "MainMenu" with your scene name
    }

    public void Retry()
    {
        SceneManager.LoadScene(retryScene); 
    }

    public void Next()
    {
        mainbg.SetActive(false);
        resultbg.SetActive(true);
    }

    public void LoadMAP()
    {
        SceneManager.LoadScene("Game"); // Replace "MainMenu" with your scene name
    }
}
