using UnityEngine;

public class LevelCollectibles : MonoBehaviour
{
    public GameObject levelCanvas;
    public GameObject item;
    private bool hasTriggered = false; // Flag to ensure it only triggers once
    public GameObject portal;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player")) // Ensure it runs only once
        {
            levelCanvas.SetActive(true);
            item.SetActive(false);
            portal.SetActive(true);
            hasTriggered = true; // Set flag to true so it won't trigger again
        }
    }

    public void canvasOff()
    {
        levelCanvas.SetActive(false);
    }
}
