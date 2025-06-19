using UnityEngine;

public class WrongBalloon : MonoBehaviour
{
    public GameObject CorrectCanvas;
    private bool hasCollided = false;
    public GameObject Balloon;
    public AudioSource pop;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            CorrectCanvas.SetActive(true);
            pop.Play();
            Balloon.SetActive(false);

        }
    }
}
