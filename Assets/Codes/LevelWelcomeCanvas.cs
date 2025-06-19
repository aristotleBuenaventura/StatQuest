using UnityEngine;

public class LevelCollider : MonoBehaviour
{
    public GameObject levelCanvas;
    private bool hasTriggered = false; // Flag to ensure it only triggers once

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player")) // Ensure it runs only once
        {
            levelCanvas.SetActive(true);
            hasTriggered = true; // Set flag to true so it won't trigger again
        }
    }

    public void canvasOff()
    {
        levelCanvas.SetActive(false);
    }
}
