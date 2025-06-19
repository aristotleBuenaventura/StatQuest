using UnityEngine;

public class TorchGameShowQuestion : MonoBehaviour
{
    public GameObject GameShowQuestion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameShowQuestion.SetActive(true);
        }
    }
}
