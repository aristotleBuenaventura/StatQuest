using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithJump : MonoBehaviour
{
    public Animator playerAnim;          // Animator for player animations
    public Rigidbody playerRigid;         // Rigidbody for player physics
    public Joystick joystick;            // Reference to the UI joystick
    public float walkSpeed = 5f;          // Walking speed
    public float backwardSpeed = 3f;      // Walking backward speed
    public float runSpeed = 8f;           // Running speed
    public float rotationSpeed = 100f;    // Rotation speed
    public float jumpForce = 7f;          // Jump force
    private float currentSpeed;          // Current movement speed
    public Transform playerTrans;         // Reference to the player's transform
    private bool isGrounded;             // Check if player is on the ground
    public bool isCarry = false;         // Flag for carrying
    public GameObject carryItem;
    void Start()
    {
        currentSpeed = walkSpeed; // Initialize current speed
    }

    void FixedUpdate()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        // Determine speed (Run if joystick is fully pushed up)
        if (vertical > 0.9f)
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        // Apply movement
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
        if (!isGrounded) return; // Don't override the jump animation while airborne

        float vertical = joystick.Vertical;

        if (isCarry)
        {
            SetAnimation("carry");
            carryItem.SetActive(true);

        }
        else if (vertical > 0.9f) // Running
        {
            SetAnimation("run");
            carryItem.SetActive(false);
        }
        else if (vertical > 0.1f) // Walking forward
        {
            SetAnimation("walk");
            carryItem.SetActive(false);
        }
        else if (vertical < -0.1f) // Walking backward
        {
            SetAnimation("walkback");
            carryItem.SetActive(false);
        }
        else // Idle
        {
            SetAnimation("idle");
            carryItem.SetActive(false);
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            SetAnimation("jump");
            isGrounded = false;
            Debug.Log("onAir");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("onGround");
        }
    }

    public void SetCarryState(bool carryState)
    {
        isCarry = carryState;
    }

    void SetAnimation(string animationTrigger)
    {
        if (animationTrigger != "jump") // Don't reset jump trigger immediately
        {
            playerAnim.ResetTrigger("idle");
            playerAnim.ResetTrigger("walk");
            playerAnim.ResetTrigger("walkback");
            playerAnim.ResetTrigger("run");
            playerAnim.ResetTrigger("carry"); // Reset carry trigger if not carrying
        }
        playerAnim.SetTrigger(animationTrigger);
    }
}