using UnityEngine;

public class CorrectTile : MonoBehaviour
{
    public GameObject answer;
    private bool hasActivated = false; // Flag to ensure it runs once
    public ProgressBar ProgressIncrease;
    public ScoreManager score;
    public AudioSource Correct;

    void OnCollisionEnter(Collision collision)
    {
        if (!hasActivated && collision.gameObject.CompareTag("Player"))
        {
            if (Correct != null)
            {
                Correct.Play(); // Play sound before destroying
            }
            hasActivated = true;
            answer.SetActive(true);
            ProgressIncrease.IncrementProgress(30);
            score.IncrementScore(5);


        }
    }
}
