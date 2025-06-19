using UnityEngine;
using System.Collections;

public class FishAnimation : MonoBehaviour
{
    public GameObject fish; // Assign the fish GameObject in the Inspector
    public float moveAmount = 0.5f; // How far the fish moves up and down
    public float moveForwardAmount = 1.0f; // How far the fish moves forward
    public float moveDuration = 2f; // Duration of the movement cycle

    private Vector3 originalPosition;

    void Start()
    {
        if (fish == null)
        {
            Debug.LogError("Fish GameObject is not assigned!");
            return;
        }

        originalPosition = fish.transform.position;
        StartCoroutine(AnimateFish());
    }

    IEnumerator AnimateFish()
    {
        while (true) // Loop infinitely
        {
            Vector3 forward = Vector3.forward * moveForwardAmount; // Move forward along the Z-axis

            yield return MoveFish(originalPosition + Vector3.up * moveAmount + forward, moveDuration / 2); // Move up and forward
            yield return MoveFish(originalPosition - Vector3.up * moveAmount + forward, moveDuration / 2); // Move down and forward
            yield return MoveFish(originalPosition, moveDuration / 2); // Return to original position
        }
    }

    IEnumerator MoveFish(Vector3 targetPosition, float duration)
    {
        Vector3 startPosition = fish.transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            fish.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fish.transform.position = targetPosition; // Ensure the final position is set
    }
}
