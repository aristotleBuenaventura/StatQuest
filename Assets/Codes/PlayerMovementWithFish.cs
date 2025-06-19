using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithItem : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public Joystick joystick;
    public float walkSpeed = 5f;
    public float backwardSpeed = 3f;
    public float runSpeed = 8f;
    public float rotationSpeed = 100f;
    public float jumpForce = 7f;
    private float currentSpeed;
    public Transform playerTrans;
    private bool isGrounded;
    public bool isCarry = false;
    public GameObject carryItem;
    public string item = "fish"; // Can be "fish" or "firefly"

    void Start()
    {
        currentSpeed = walkSpeed;
    }

    void FixedUpdate()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        currentSpeed = (vertical > 0.9f) ? runSpeed : walkSpeed;

        Vector3 movement = Vector3.zero;
        if (vertical > 0.1f)
        {
            movement = transform.forward * currentSpeed * vertical;
        }
        else if (vertical < -0.1f)
        {
            movement = -transform.forward * backwardSpeed * Mathf.Abs(vertical);
        }
        playerRigid.linearVelocity = new Vector3(movement.x, playerRigid.linearVelocity.y, movement.z);

        if (Mathf.Abs(horizontal) > 0.1f)
        {
            playerTrans.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        }
    }

    void Update()
    {
        if (!isGrounded) return;

        float vertical = joystick.Vertical;

        if (isCarry)
        {
            SetAnimation(item);
            carryItem.SetActive(true);
        }
        else if (vertical > 0.9f)
        {
            SetAnimation("run");
            carryItem.SetActive(false);
        }
        else if (vertical > 0.1f)
        {
            SetAnimation("walk");
            carryItem.SetActive(false);
        }
        else if (vertical < -0.1f)
        {
            SetAnimation("walkback");
            carryItem.SetActive(false);
        }
        else
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
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void SetCarryState(bool carryState, string newItem)
    {
        isCarry = carryState;
        item = newItem;
    }

    void SetAnimation(string animationTrigger)
    {
        if (animationTrigger != "jump")
        {
            playerAnim.ResetTrigger("idle");
            playerAnim.ResetTrigger("walk");
            playerAnim.ResetTrigger("walkback");
            playerAnim.ResetTrigger("run");
            playerAnim.ResetTrigger("fish");
            playerAnim.ResetTrigger("firefly");
        }
        playerAnim.SetTrigger(animationTrigger);
    }
}
