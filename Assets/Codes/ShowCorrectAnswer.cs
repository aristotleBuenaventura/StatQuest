using UnityEngine;

public class ShowCorrectAnswer : MonoBehaviour
{
    public GameObject CorrectCanvas;
    private bool hasCollided = false;
    public AudioSource Correct;
    public ScoreManager score;
    public ProgressBar percent;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            CorrectCanvas.SetActive(true);
            score.IncrementScore(1);
            percent.IncrementProgress(3);
            Correct.Play();
        }
    }

}
