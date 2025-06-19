using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTransitionFromS1ToMap : MonoBehaviour
{
    public ProgressManager increaseLevel;
    public GameObject results, portal;
    public TimerDisplay time;
    public ScoreManager score;
    public BadgeManager badge;
    public int MinScore = 0;
    public GameObject withBadge, noBadge;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with a box (or any specific tag if you want)
        if (collision.gameObject.CompareTag("Map"))
        {
            results.SetActive(true);
            increaseLevel.IncrementLevel();
            time.StopTimer();
            portal.SetActive(false);

            // Corrected to use BadgeManager.BadgeType enum
            if (score.GetScore() >= MinScore)
            {
                badge.SaveBadge(BadgeManager.BadgeType.True);
                withBadge.SetActive(true);
                noBadge.SetActive(false);
            } else
            {
                badge.SaveBadge(BadgeManager.BadgeType.False);
                withBadge.SetActive(false);
                noBadge.SetActive(true);
            }
        }
    }
}
