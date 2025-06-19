using System.Collections;
using UnityEngine;

public class FireflyMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of circular movement
    public float circleRadius = 5f; // Radius of the circular movement
    public float verticalSpeed = 1f; // Speed of the up-and-down movement
    public float flickerSpeed = 0.5f; // Speed of flickering
    public float minLightIntensity = 0.5f; // Minimum light intensity
    public float maxLightIntensity = 1.5f; // Maximum light intensity
    public bool rotateClockwise = true; // Determines the rotation direction (true = clockwise, false = counterclockwise)

    private Light fireflyLight;
    private float angle = 0f; // Current angle in the circular movement
    private Vector3 centerPosition;

    void Start()
    {
        // Add the light component if it doesn't exist yet
        fireflyLight = gameObject.AddComponent<Light>();
        fireflyLight.type = LightType.Point;
        fireflyLight.intensity = Random.Range(minLightIntensity, maxLightIntensity); // Random light intensity

        // Set the center position (the origin of the circular movement)
        centerPosition = transform.position;
    }

    void Update()
    {
        // Update the angle based on rotation direction (clockwise or counterclockwise)
        float rotationDirection = rotateClockwise ? 1f : -1f;
        angle += rotationDirection * speed * Time.deltaTime; // Increment the angle based on speed

        if (angle >= 360f) angle = 0f; // Reset angle to avoid overflow

        // Calculate the circular position
        float x = Mathf.Cos(angle) * circleRadius;
        float z = Mathf.Sin(angle) * circleRadius;

        // Add vertical movement (up and down oscillation)
        float y = Mathf.Sin(Time.time * verticalSpeed) * 2f; // Sine wave for vertical motion

        // Set the new position
        transform.position = centerPosition + new Vector3(x, y, z);

        // Flicker the light by randomly changing intensity over time
        FlickerLight();
    }

    // Function to simulate flickering light
    void FlickerLight()
    {
        fireflyLight.intensity = Mathf.Lerp(minLightIntensity, maxLightIntensity, Mathf.PingPong(Time.time * flickerSpeed, 1));
    }
}
