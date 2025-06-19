using UnityEngine;

public class DialogueDisplayFirefly : MonoBehaviour
{
    public GameObject D1;
    private bool hasCollided = false;
    public GameObject circle;
    public FireflyTrigger firefly;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            D1.SetActive(true);
            firefly.isCatching = true;
            circle.SetActive(false);

        }
    }
}
