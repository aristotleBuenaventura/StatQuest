using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject player;
    public float teleportX = 0f;
    public float teleportY = 0f;
    public float teleportZ = 0f;

    private void Start()
    {
        // Ensure the GameObject has a BoxCollider
        if (GetComponent<BoxCollider>() == null)
        {
            gameObject.AddComponent<BoxCollider>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Teleport();
        }
    }

    public void Teleport()
    {
        if (player != null)
        {
            player.transform.position = new Vector3(teleportX, teleportY, teleportZ);
        }
    }
}