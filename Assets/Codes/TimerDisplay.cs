using UnityEngine;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float elapsedTime = 0f;
    private bool isRunning = true; // Timer starts running by default

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;

            int hours = Mathf.FloorToInt(elapsedTime / 3600);
            int minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }

    // Function to stop the timer
    public void StopTimer()
    {
        isRunning = false;
    }

    // Getter function to retrieve the timer text
    public string GetTimerText()
    {
        return timerText.text;
    }
}
