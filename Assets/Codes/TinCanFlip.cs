using UnityEngine;
using System.Collections;

public class TinCanFlip : MonoBehaviour
{
    public Rigidbody rb;
    public float rollForce = 5f;
    public float spinForce = 10f;
    public Transform[] diceFaces; // Assign in Inspector
    private Vector3 startPosition;
    private Quaternion startRotation;
    private bool isRolling = false;
    public GameObject One, Two, Three, FlipCanvas;
    private int rollCount = 0; // Track the number of rolls

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

        if (rb == null)
            rb = GetComponent<Rigidbody>();

        // Ensure these GameObjects are initially inactive
        One.SetActive(false);
        Two.SetActive(false);
        Three.SetActive(false);
    }

    public void RollDice()
    {
        if (!isRolling) // Prevent multiple rolls at once
        {
            StartCoroutine(RollRoutine());
        }
    }

    IEnumerator RollRoutine()
    {
        isRolling = true;

        // Reset position & rotation
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition;
        transform.rotation = startRotation;

        yield return new WaitForSeconds(0.1f);

        // Apply force upward
        rb.AddForce(Vector3.up * rollForce, ForceMode.Impulse);

        // Apply random spin
        rb.AddTorque(Random.Range(-spinForce, spinForce),
                    Random.Range(-spinForce, spinForce),
                    Random.Range(-spinForce, spinForce), ForceMode.Impulse);

        yield return new WaitForSeconds(2f); // Wait for dice to settle

        // Get rolled value
        int rolledValue = GetRolledValue();

        // Handle dice roll results with revised if-else
        if (rolledValue == 1)
        {
            Debug.Log("You rolled a 1!");
            rollCount++; // Increment roll count

            if (rollCount == 1)
            {
                One.SetActive(true);
                FlipCanvas.SetActive(false);
            }
            else if (rollCount == 2)
            {
                One.SetActive(false);
                Two.SetActive(true);
                FlipCanvas.SetActive(false);
            }
            else if (rollCount == 3)
            {
                One.SetActive(false);
                Two.SetActive(false);
                Three.SetActive(true);
                FlipCanvas.SetActive(false);
            }
        }
        else if (rolledValue == 2)
        {
            Debug.Log("You rolled a 2!");
        }
        else if (rolledValue == 3)
        {
            Debug.Log("You rolled a 3!");
        }
        else if (rolledValue == 4)
        {
            Debug.Log("You rolled a 4!");
        }
        else if (rolledValue == 5)
        {
            Debug.Log("You rolled a 5!");
        }
        else if (rolledValue == 6)
        {
            Debug.Log("You rolled a 6!");
            rollCount++; // Increment roll count

            if (rollCount == 1)
            {
                One.SetActive(true);
                FlipCanvas.SetActive(false);
            }
            else if (rollCount == 2)
            {
                One.SetActive(false);
                Two.SetActive(true);
                FlipCanvas.SetActive(false);
            }
            else if (rollCount == 3)
            {
                One.SetActive(false);
                Two.SetActive(false);
                Three.SetActive(true);
                FlipCanvas.SetActive(false);
            }
        }

        isRolling = false;
    }

    int GetRolledValue()
    {
        int bestFace = 1;
        float highestY = float.MinValue;

        for (int i = 0; i < diceFaces.Length; i++)
        {
            if (diceFaces[i].position.y > highestY)
            {
                highestY = diceFaces[i].position.y;
                bestFace = i + 1; // Face numbers are 1-6
            }
        }
        return bestFace;
    }
}