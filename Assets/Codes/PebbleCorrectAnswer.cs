using UnityEngine;
using System.Collections.Generic; // Needed for HashSet

public class PebbleCorrectAnswer : MonoBehaviour
{
    public GameObject D39;
    public GameObject I41;
    public PebbleChecker check;
    public GameObject WrongPebble;
    public GameObject pebbles;
    public GameObject scale;
    public AudioSource Correct;
    public ScoreManager score;
    public ProgressBar percent;

    private HashSet<string> collidedPebbles = new HashSet<string>(); // Tracks unique pebbles
    private int collisionCount = 0; // Tracks unique collisions

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        Debug.Log("Collided with: " + collision.gameObject.name);
        string pebbleName = check.PebbleName;

        // Check for unique pebble collisions
        if (!collidedPebbles.Contains(pebbleName) &&
            (pebbleName == "Pebble2Violet" || pebbleName == "Pebble2Pink"))
        {
            collidedPebbles.Add(pebbleName); // Store unique pebble
            collisionCount++;

            if (collisionCount == 1)
            {
                Correct.Play();
                score.IncrementScore(5);
                percent.IncrementProgress(5);
                D39.SetActive(true); // First unique pebble activates D39
            }
            else if (collisionCount == 2)
            {
                Correct.Play();
                percent.IncrementProgress(5);
                score.IncrementScore(5);
                I41.SetActive(true); // Second unique pebble activates I41
                pebbles.SetActive(false);
                scale.SetActive(true);
            }
        }
        // Check for Pebble7, Pebble26, or Pebble11 and log "DONE"
        else if (pebbleName == "Pebble7" || pebbleName == "Pebble26" || pebbleName == "Pebble11")
        {
            WrongPebble.SetActive(true);
        }
    }

    public void WrongPebbleClose()
    {
        WrongPebble.SetActive(false);
    }
}
