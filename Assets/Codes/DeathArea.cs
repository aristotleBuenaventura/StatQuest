using UnityEngine;

public class DeathArea : MonoBehaviour
{
    public LifeManager life;
    public float teleportX = 18.6f;
    public float teleportY = 7.25f;
    public float teleportZ = -45.4f;
    public ScoreManager score;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Teleport the player that collided
            collision.gameObject.transform.position = new Vector3(teleportX, teleportY, teleportZ);
            score.DecrementScore(5);
            life.DecreaseLife();
        }
    }
}
