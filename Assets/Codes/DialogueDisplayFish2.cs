using UnityEngine;

public class DialogueDisplayFish2 : MonoBehaviour
{
    public GameObject D1;
    private bool hasCollided = false;
    public GameObject circle;
    public FishTrigger2 fish;

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
