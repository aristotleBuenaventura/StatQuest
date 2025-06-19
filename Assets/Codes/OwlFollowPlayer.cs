using UnityEngine;

public class OwlFollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float speed = 5f; // Speed of the owl
    public float stoppingDistance = 3f; // Increased distance to stop near the player
    public float heightOffset = 2f; // Height offset to keep the owl above the player
    public bool canFollow = false; // Boolean to control if the owl should follow

    void Update()
    {
        if (canFollow && player != null)
        {
            Vector3 targetPosition = player.position + new Vector3(0, heightOffset, 0); // Adjust height
            float distance = Vector3.Distance(transform.position, targetPosition);

            if (distance > stoppingDistance)
            {
                // Move towards the player while maintaining height
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }

            // Rotate to face the player
            Vector3 direction = (player.position - transform.position).normalized;
            if (direction != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
            }
        }
    }
}