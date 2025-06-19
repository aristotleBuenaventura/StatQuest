using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

public class ProgressBar : MonoBehaviour
{
    public Slider progressSlider; // Assign UI Slider in Inspector
    public TMP_Text progressText; // Assign TMP text in Inspector

    void Start()
    {
        progressSlider.value = 0; // Start at 0
        progressSlider.maxValue = 100; // Set max value to 100
        UpdateProgressText(); // Initialize text
    }

    public void IncrementProgress(int amount)
    {
        progressSlider.value += amount;
        if (progressSlider.value > 100)
        {
            progressSlider.value = 100; // Ensure it doesn’t exceed 100
        }
        UpdateProgressText(); // Update text after increment
    }

    public void ResetProgress()
    {
        progressSlider.value = 0; // Reset progress to 0
        UpdateProgressText(); // Update text after reset
    }

    private void UpdateProgressText()
    {
        progressText.text = progressSlider.value + "%"; // Display progress value
    }
}
