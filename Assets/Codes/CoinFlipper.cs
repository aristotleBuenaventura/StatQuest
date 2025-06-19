using UnityEngine;
using System.Collections;
using TMPro; // Required for TextMeshPro

public class CoinFlipper : MonoBehaviour
{
    public Rigidbody rb;
    public float flipForce = 5f;
    public float spinForce = 10f;
    public GameObject CoinFlip; // Reference to the GameObject that will be disabled
    public TMP_Text flipsText;  // Reference to the TextMeshPro UI element
    public DialogueDisplay display;
    public ProgressBar ProgressIncrease;
    private bool isOnGround = false;
    private int currentFlips = 0; // Tracks the number of flips
    private int maxFlips = 0; // Stores the max flips
    private int remainingFlips = 0; // Countdown for remaining flips

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        rb.isKinematic = false; // Ensure physics is applied
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }

    // Method to set the maximum flips (Call this before flipping)
    public void SetMaxFlips(int flips)
    {
        maxFlips = flips;
        remainingFlips = flips; // Set countdown to maxFlips
        currentFlips = 0; // Reset the counter when setting a new max flips
        UpdateFlipsText(); // Update UI text
    }

    // Method to flip the coin (Call this from a button)
    public void FlipCoin()
    {
        if (!isOnGround || remainingFlips <= 0) return; // Only flip if on the ground and remaining flips > 0

        // Reset velocity to ensure consistent flips
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Apply an upward force
        rb.AddForce(Vector3.up * flipForce, ForceMode.Impulse);

        // Apply a random spin
        rb.AddTorque(
            Random.Range(-spinForce, spinForce),
            Random.Range(-spinForce, spinForce),
            Random.Range(-spinForce, spinForce),
            ForceMode.Impulse
        );

        isOnGround = false; // Prevent multiple flips mid-air

        // Increment flip count
        currentFlips++;

        // Decrement remaining flips and update the text each time
        remainingFlips--;
        UpdateFlipsText(); // Update countdown UI

        // Check if flip count reached the target
        if (remainingFlips <= 0) // Once it hits 0, stop flipping
        {
            Debug.Log("DONE");
            StartCoroutine(DisableCoinFlipAfterDelay(3f)); // Call coroutine to disable after delay
            currentFlips = 0; // Reset counter for the next flip session
        }
    }

    // Coroutine to disable CoinFlip after a delay
    private IEnumerator DisableCoinFlipAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        CoinFlip.SetActive(false);
        if (maxFlips == 4) // Ensure it's when flips have ended
        {
            display.D5Show();
            ProgressIncrease.IncrementProgress(10);

        }
    }

    // Update TMP text UI for countdown
    private void UpdateFlipsText()
    {
        if (flipsText != null)
        {
            // Show remaining flips and handle singular/plural "time"
            if (remainingFlips <= 1)
            {
                flipsText.text = remainingFlips.ToString() + " time!"; // Singular "time" for 1 or less
            }
            else
            {
                flipsText.text = remainingFlips.ToString() + " times!"; // Plural "times" for greater than 1
            }
        }
    }

    // Reset flip values after each round
    private void ResetFlips()
    {
        currentFlips = 0; // Reset current flips
        remainingFlips = 0; // Do not reset remaining flips back to maxFlips
        UpdateFlipsText(); // Update the countdown text
    }
}
