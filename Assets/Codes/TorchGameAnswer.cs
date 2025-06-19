using UnityEngine;
using TMPro;

public class TorchGameAnswer : MonoBehaviour
{
    public TMP_InputField userInput;
    public int correctAnswer = 0; // Default value is 0
    public GameObject TorchFire;
    public GameObject Canvas;
    public GameObject portalShowingCanvas, CorrectCanvas;
    public CorrectCounter counter;
    public AudioSource Correct;
    public AudioSource Wrong;
    public ScoreManager score;
    public ProgressBar percent;

    public void CheckAnswer()
    {
        if (int.TryParse(userInput.text, out int userAnswer) && userAnswer == correctAnswer)
        {
            Debug.Log("Correct");
            Correct.Play();
            TorchFire.SetActive(true);
            Canvas.SetActive(false);
            portalShowingCanvas.SetActive(false);
            counter.Increment();
            CorrectCanvas.SetActive(true);
            score.IncrementScore(1);
            percent.IncrementProgress(3);
        }
        else
        {
            Wrong.Play();
            score.DecrementScore(2);

            Debug.Log("Incorrect");
        }
    }

    public void CanvasClose()
    {
        Canvas.SetActive(false);
    }

    public void CorrectCanvasClose()
    {
        CorrectCanvas.SetActive(false);
    }
}