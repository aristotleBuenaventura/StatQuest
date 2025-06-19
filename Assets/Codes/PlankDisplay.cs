using UnityEngine;

public class PlankDisplay : MonoBehaviour
{
    private bool hasTriggered = false;
    public PlayerWithJump PlankOnHand;
    public GameObject UIDice;
    public GameObject PlankOnBridgeFix;
    public GameObject PlankOnBridgeBroken;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Plank"))
        {
            PlankOnHand.SetCarryState(false);
            UIDice.SetActive(true);
            PlankOnBridgeBroken.SetActive(false);
            PlankOnBridgeFix.SetActive(true);
            hasTriggered = true;
        }
    }
}
