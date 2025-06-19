using UnityEngine;
using System.Collections.Generic; // Needed for HashSet

public class RuneCorrectAppear : MonoBehaviour
{
    public GameObject RunePillar, Circle, WrongCanvas, CorrectCanvas;
    public PlayerWithJump carryRune;
    public string rune;
    public RuneChecker setRune;
    public GameObject Rune1Option1, Rune2Option1, Rune3Option1;
    public GameObject Rune1Option2, Rune2Option2, Rune3Option2;
    public GameObject Rune1Option3, Rune2Option3, Rune3Option3;
    public GameObject CorrectAnswerCanvas;
    public ScoreManager score;
    public ProgressBar percent;

    private HashSet<string> collidedRunes = new HashSet<string>(); // Tracks collided rune names

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !collidedRunes.Contains(setRune.RuneName))
        {
            collidedRunes.Add(setRune.RuneName); // Mark this rune as processed

            if (setRune.RuneName == rune)
            {
                RunePillar.SetActive(true);
                carryRune.SetCarryState(false);
                Circle.SetActive(false);
                Debug.Log("Collided with " + rune);
                CorrectCanvas.SetActive(true);

                Rune1Option1.SetActive(true);
                Rune1Option2.SetActive(true);
                Rune1Option3.SetActive(true);

                Rune2Option1.SetActive(true);
                Rune2Option2.SetActive(true);
                Rune2Option3.SetActive(true);

                Rune3Option1.SetActive(true);
                Rune3Option2.SetActive(true);
                Rune3Option3.SetActive(true);
                score.IncrementScore(10);
                percent.IncrementProgress(34);
                CorrectAnswerCanvas.SetActive(true);
            }
            else
            {
                score.DecrementScore(5); // Runs only once per unique rune collision
                WrongCanvas.SetActive(true);
            }
        }
    }
}
