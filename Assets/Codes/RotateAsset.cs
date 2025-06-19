using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAsset : MonoBehaviour
{
    public float rotationSpeed = 20f; // Speed at which the portal rotates along its Y-axis
    public GameObject item; // Reference to the portal GameObject

    void Start()
    {
        // Ensure the portal's Rigidbody has its position and rotation frozen on the X and Z axes
        Rigidbody portalRigidbody = item.GetComponent<Rigidbody>();
        if (portalRigidbody != null)
        {
            portalRigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
    }

    void Update()
    {
        if (item != null)
        {
            // Rotate the portal continuously around the Y-axis
            item.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}
