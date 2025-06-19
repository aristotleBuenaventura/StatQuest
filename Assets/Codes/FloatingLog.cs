using UnityEngine;

public class FloatingLog : MonoBehaviour
{
    public float floatSpeed = 0.5f; // Speed of floating motion
    public float floatHeight = 0.3f; // Height variation for floating

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Store the initial position
    }

    void Update()
    {
        // Smooth up and down motion using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Apply the new position while keeping X and Z unchanged
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
