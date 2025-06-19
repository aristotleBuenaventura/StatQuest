using UnityEngine;
using System.Collections;

public class FireflyTrigger : MonoBehaviour
{
    public PlayerWithItem firefly;
    public GameObject player;
    private bool isFirefly = false;
    private Coroutine timerCoroutine;
    private int remainingTime = 25; // Store remaining time
    public bool isCatching = false; // Only allow timer when true
    public GameObject I4;

    void OnTriggerEnter(Collider other)
    {
        if (isCatching && other.gameObject == player)
        {
            if (firefly != null && !isFirefly)
            {
                firefly.SetCarryState(true, "firefly");
                Debug.Log("Player entered firefly trigger: Carrying firefly.");

                // Resume countdown if it was stopped
                if (timerCoroutine == null && remainingTime > 0)
                {
                    timerCoroutine = StartCoroutine(TimerCountdown());
                }
            }
            else
            {
                Debug.LogError("Firefly reference is not assigned in FireflyTrigger.");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isCatching && other.gameObject == player)
        {
            if (!isFirefly) // Only drop the firefly if the timer hasn't completed
            {
                if (firefly != null)
                {
                    firefly.SetCarryState(false, "firefly");
                    Debug.Log("Player exited firefly trigger: Dropped firefly.");
                }
                else
                {
                    Debug.LogError("Firefly reference is not assigned in FireflyTrigger.");
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
        firefly.SetCarryState(false, "firefly");
        isFirefly = true;
        Debug.Log("Done");
        I4.SetActive(true);
        timerCoroutine = null; // Reset the coroutine reference
    }
}
