using UnityEngine;
using System.Collections;
using TMPro;

public class DiceRoller : MonoBehaviour
{
    public PlayerWithJump PlankOnHand;
    public Rigidbody rb;
    public float rollForce = 5f;
    public float spinForce = 10f;
    public Transform[] diceFaces; // Assign in Inspector
    public ScoreManager score;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private bool isRolling = false;
    public GameObject RollDiceCanvas;
    private bool hasPlayedFindPlank1 = false;
    public GameObject Plank1Canvas;
    public GameObject Plank2Canvas;
    public GameObject Plank3Canvas;

    public GameObject Plank1Fix;
    public GameObject Plank2Fix;
    public GameObject Plank3Fix;

    public GameObject Plank1Broken;
    public GameObject Plank2Broken;
    public GameObject Plank3Broken;

    public GameObject Portal;
    public GameObject D3;

    private bool hasRolled3 = false;
    private bool hasRolled5 = false;
    private bool hasRolled6 = false;

    public GameObject UIDice;
    public ProgressBar progress;
    public AudioSource Correct;
    public AudioSource Wrong;
    public AudioSource FindPlank1;
    public AudioSource FindPlank2;
    public AudioSource FindPlank3;
    private int counter = 0;

    public TMP_Text rollValueText; // TextMeshPro UI Text

    void Start()
    {
        RollDiceCanvas.SetActive(false);
        startPosition = transform.position;
        startRotation = transform.rotation;

        if (rb == null)
            rb = GetComponent<Rigidbody>();

        if (rollValueText != null)
            rollValueText.text = "1";
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
        Debug.Log("Rolled Value: " + rolledValue);

        // Update UI text
        if (rollValueText != null)
        {
            rollValueText.text = rolledValue.ToString();
        }

        // Handle dice roll results
        if (rolledValue == 1)
        {
            Debug.Log("You rolled a 1!");
            Wrong.Play();
        }
        else if (rolledValue == 2)
        {
            Debug.Log("You rolled a 2!");
            Wrong.Play();
        }
        else if (rolledValue == 3 && !hasRolled3)
        {
            Debug.Log("You rolled a 3!");
            score.IncrementScore(5);
            progress.IncrementProgress(34);
            yield return new WaitForSeconds(2f); // Delay before activating Plank1Canvas
            Plank1Canvas.SetActive(true);
            PlankOnHand.SetCarryState(true);
            UIDice.SetActive(false);
            Correct.Play();
            hasRolled3 = true;          
        }
        else if (rolledValue == 3 && hasRolled3)
        {
            Wrong.Play();
        }
        else if (rolledValue == 4)
        {
            Debug.Log("You rolled a 4!");
            Wrong.Play();
        }
        else if (rolledValue == 5 && hasRolled3 && !hasRolled5)
        {
            Debug.Log("You rolled a 5!");
            score.IncrementScore(5);
            progress.IncrementProgress(34);
            yield return new WaitForSeconds(2f); // Delay before activating Plank2Canvas
            Plank2Canvas.SetActive(true);
            PlankOnHand.SetCarryState(true);
            UIDice.SetActive(false);
            Correct.Play();
            hasRolled5 = true;
        }
        else if (rolledValue == 5)
        {
            Wrong.Play();
        }
        else if (rolledValue == 6 && hasRolled3 && hasRolled5 && !hasRolled6)
        {
            Debug.Log("You rolled a 6!");
            score.IncrementScore(5);
            progress.IncrementProgress(34);
            yield return new WaitForSeconds(2f); // Delay before activating Plank3Canvas
            Plank3Canvas.SetActive(true);
            PlankOnHand.SetCarryState(true);
            UIDice.SetActive(false);
            Correct.Play();
            hasRolled6 = true;
        }
        else if (rolledValue == 6)
        {
            Wrong.Play();
        }

        if (hasRolled3 && hasRolled5 && hasRolled6)
        {
            Debug.Log("DONE");
            Portal.SetActive(true);
        }

        yield return new WaitForSeconds(2f); // Delay before hiding the RollDiceCanvas
        RollDiceCanvas.SetActive(false);

        isRolling = false;
    }



    

    public void OpenRollDice()
    {
        if (!hasPlayedFindPlank1)
        {
            FindPlank1.Play();
            hasPlayedFindPlank1 = true;
        }

        RollDiceCanvas.SetActive(true);
        D3.SetActive(false);
    }


    public void ClosePlankCanvasses()
    {
        counter++;
        Plank1Canvas.SetActive(false);
        Plank2Canvas.SetActive(false);
        Plank3Canvas.SetActive(false);
        if (counter == 1)
        {
            FindPlank2.Play();
        } else if (counter == 2)
        {
            FindPlank3.Play();
        }
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
