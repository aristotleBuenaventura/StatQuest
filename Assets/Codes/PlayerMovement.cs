using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnim;         // Animator for player animations
    public Rigidbody playerRigid;       // Rigidbody for player physics
    public Joystick joystick;           // Reference to the UI joystick
    public float walkSpeed = 5f;        // Walking speed
    public float backwardSpeed = 3f;    // Walking backward speed
    public float runSpeed = 8f;         // Running speed
    public float rotationSpeed = 100f;  // Rotation speed
    private float currentSpeed;         // Current movement speed
    public Transform playerTrans;       // Reference to the player's transform

    void Start()
    {
        // Initialize current speed to walk speed
        currentSpeed = walkSpeed;
    }

    void FixedUpdate()
    {
        // Get joystick input
        float horizontal = joystick.Horizontal; // Left-right movement
        float vertical = joystick.Vertical;     // Forward-backward movement

        // Determine speed (Run if joystick is fully pushed up)
        if (vertical > 0.9f) // If joystick is nearly maxed out upward
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        // Apply forward/backward movement
        Vector3 movement = Vector3.zero;
        if (vertical > 0.1f) // Forward
        {
            movement = transform.forward * currentSpeed * vertical;
        }
        else if (vertical < -0.1f) // Backward
        {
            movement = -transform.forward * backwardSpeed * Mathf.Abs(vertical);
        }
        playerRigid.linearVelocity = new Vector3(movement.x, playerRigid.linearVelocity.y, movement.z);

        // Apply rotation
        if (Mathf.Abs(horizontal) > 0.1f)
        {
            playerTrans.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        }
    }

    void Update()
    {
        // Get joystick input
        float vertical = joystick.Vertical;

        // Handle animations
        if (vertical > 0.9f) // Running (Joystick pushed fully up)
        {
            playerAnim.ResetTrigger("idle");
            playerAnim.ResetTrigger("walk");
            playerAnim.ResetTrigger("walkback");
            playerAnim.SetTrigger("run");
        }
        else if (vertical > 0.1f) // Walking forward
        {
            playerAnim.ResetTrigger("idle");
            playerAnim.ResetTrigger("walkback");
            playerAnim.ResetTrigger("run");
            playerAnim.SetTrigger("walk");
        }
        else if (vertical < -0.1f) // Walking backward
        {
            playerAnim.ResetTrigger("idle");
            playerAnim.ResetTrigger("walk");
            playerAnim.ResetTrigger("run");
            playerAnim.SetTrigger("walkback");
        }
        else // Idle
        {
            playerAnim.ResetTrigger("walk");
            playerAnim.ResetTrigger("walkback");
            playerAnim.ResetTrigger("run");
            playerAnim.SetTrigger("idle");
        }
    }
}
