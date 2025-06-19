using UnityEngine;
using System.Collections;

public class FishTrigger2 : MonoBehaviour
{
    public PlayerWithItem fish;
    public GameObject player;
    private bool isFish = false;
    private Coroutine timerCoroutine;
    private int remainingTime = 9; // Store remaining time
    public bool isFishing = false; // Only allow timer when true
    public GameObject I1;

    void OnTriggerEnter(Collider other)
    {
        if (isFishing && other.gameObject == player)
        {
            if (fish != null && !isFish)
            {
                fish.SetCarryState(true, "fish");
                Debug.Log("Player entered fish trigger: Carrying fish.");

                // Resume countdown if it was stopped
                if (timerCoroutine == null && remainingTime > 0)
                {
                    timerCoroutine = StartCoroutine(TimerCountdown());
                }
            }
            else
            {
                Debug.LogError("Fish reference is not assigned in FishTrigger.");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isFishing && other.gameObject == player)
        {
            if (!isFish) // Only drop the fish if the timer hasn't completed
            {
                if (fish != null)
                {
                    fish.SetCarryState(false, "fish");
                    Debug.Log("Player exited fish trigger: Dropped fish.");
                }
                else
                {
                    Debug.LogError("Fish reference is not assigned in FishTrigger.");
                }

                // Pause the countdown when the player exits
                if (timerCoroutine != null)
                {
                    StopCoroutine(timerCoroutine);
                    timerCoroutine = null;
                    Debug.Log("Timer paused at: " + remainingTime + " seconds.");
                }
            }
        }
    }

    private IEnumerator TimerCountdown()
    {
        while (remainingTime > 0)
        {
            Debug.Log("Time remaining: " + remainingTime + " seconds");
            yield return new WaitForSeconds(1);
            remainingTime--;
        }
        fish.SetCarryState(false, "fish");
        isFish = true;
        Debug.Log("Done");
        I1.SetActive(true);
        timerCoroutine = null; // Reset the coroutine reference
    }
}
