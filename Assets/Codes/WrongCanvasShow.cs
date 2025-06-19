using UnityEngine;

public class WrongCanvasShow : MonoBehaviour
{
    public GameObject WrongCanvas;
    private bool hasCollided = false;
    public AudioSource Wrong;
    public ScoreManager score;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            WrongCanvas.SetActive(true);
            score.DecrementScore(2);
            Wrong.Play();
            Debug.Log("Wrong");
        }
    }

    public void WrongCanvasClose()
    {
        WrongCanvas.SetActive(false);
    }
}