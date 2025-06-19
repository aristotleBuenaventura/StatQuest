using UnityEngine;

public class HighlightPlayerWhenBlocked : MonoBehaviour
{
    public Camera mainCamera; // Reference to the main camera
    public GameObject player; // Reference to the player object
    public Color highlightColor = Color.red; // The color to highlight the player
    public float raycastDistance = 10f; // Raycast distance from the camera
    private Renderer playerRenderer;
    private Color originalColor;

    void Start()
    {
        // Get the player's renderer component to modify its color
        playerRenderer = player.GetComponent<Renderer>();
        if (playerRenderer != null)
        {
            originalColor = playerRenderer.material.color;
        }

        if (mainCamera == null)
        {
            mainCamera = Camera.main; // Use the main camera if not assigned
        }
    }

    void Update()
    {
        // Cast a ray from the camera to the player
        RaycastHit hit;
        Vector3 directionToPlayer = player.transform.position - mainCamera.transform.position;

        // Check if there is any obstruction (e.g., wall) between the camera and player
        if (Physics.Raycast(mainCamera.transform.position, directionToPlayer, out hit, raycastDistance))
        {
            if (hit.collider.gameObject.CompareTag("Plank"))
            {
                HighlightPlayer(); // Highlight player when blocked by a wall
            }
            else
            {
                ResetHighlight(); // Reset if no obstruction is present
            }
        }
        else
        {
            ResetHighlight(); // Reset if no obstruction
        }
    }

    // Change the player's color to indicate they are blocked
    void HighlightPlayer()
    {
        if (playerRenderer != null)
        {
            // Optionally, add a glowing or outline effect
            playerRenderer.material.color = highlightColor; // Example color change
        }
    }

    // Reset the player's color to its original state
    void ResetHighlight()
    {
        if (playerRenderer != null)
        {
            playerRenderer.material.color = originalColor;
        }
    }
}
