using UnityEngine;

public class WateringAnimation : MonoBehaviour
{
    public float countdownTime = 5f; // Set this in Inspector
    private float currentCountdown;
    private bool isPlayerInside = false;
    private bool isDone = false;

    public PlantCounter counter;
    public string potTag; // Set this to the desired pot tag in Inspector

    public GameObject WateringCanOnHand, defaultPlant, GrowPlant;
    public Animator animator; // Set this manually in Inspector

    void Start()
    {
        currentCountdown = countdownTime;
        Debug.Log("WateringAnimation (3D) script started.");
    }

    void Update()
    {
        if (isPlayerInside && !isDone)
        {
            currentCountdown -= Time.deltaTime;
            Debug.Log("Countdown running: " + currentCountdown.ToString("F2"));

            if (currentCountdown <= 0f)
            {
                isDone = true; // Ensure this is set first to prevent multiple triggers
                counter.Increment();
                defaultPlant.SetActive(false);
                GrowPlant.SetActive(true);
                WateringCanOnHand.SetActive(false);
                animator.ResetTrigger("water");
                Debug.Log("Done");
            }
            else if (currentCountdown <= 7f)
            {
                animator.SetTrigger("water");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag(potTag) && !isDone)
        {
            isPlayerInside = true;
            WateringCanOnHand.SetActive(true);
            animator.SetTrigger("water");
            Debug.Log("Player entered pot with tag: " + potTag + ". Triggering water animation.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag(potTag))
        {
            isPlayerInside = false;
            WateringCanOnHand.SetActive(false);
            Debug.Log("Player exited pot with tag: " + potTag + ". Countdown paused at: " + currentCountdown.ToString("F2"));
        }
    }
}
