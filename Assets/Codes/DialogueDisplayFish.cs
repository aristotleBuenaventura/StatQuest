using UnityEngine;

public class DialogueDisplayFish : MonoBehaviour
{
    public GameObject D1;
    private bool hasCollided = false;
    public GameObject circle;
    public FishTrigger fish;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            D1.SetActive(true);
            fish.isFishing = true;
            circle.SetActive(false);

        }
    }
}
