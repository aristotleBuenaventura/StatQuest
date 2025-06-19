using UnityEngine;

public class MoveStones : MonoBehaviour
{
    public GameObject Stones;
    public float targetY = -46.04f;
    public float moveSpeed = 1f; // Adjust speed as needed

    private void Update()
    {
        if (Stones != null)
        {
            // Move the stone from current Y position to the target Y
            float newY = Mathf.MoveTowards(Stones.transform.position.y, targetY, moveSpeed * Time.deltaTime);
            Stones.transform.position = new Vector3(Stones.transform.position.x, newY, Stones.transform.position.z);

            // Optionally, you can stop moving when the target is reached
            if (newY == targetY)
            {
                enabled = false; // Disables the script once the movement is done
            }
        }
    }
}
