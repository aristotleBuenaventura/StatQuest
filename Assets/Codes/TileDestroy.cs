using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    public ScoreManager score;
    public AudioSource Wrong; // Reference to the AudioSource

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            score.DecrementScore(2);

            if (Wrong != null)
            {
                Wrong.Play(); // Play sound before destroying
            }

            Destroy(gameObject);
            // Delay destruction if audio exists
        }
    }
}
