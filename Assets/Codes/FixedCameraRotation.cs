using UnityEngine;

public class FixedCameraRotation : MonoBehaviour
{
    // Desired fixed rotation values
    private Quaternion fixedRotation = Quaternion.Euler(90f, 0f, 0f);

    void Update()
    {
        // Apply the fixed rotation
        transform.rotation = fixedRotation;
    }
}
