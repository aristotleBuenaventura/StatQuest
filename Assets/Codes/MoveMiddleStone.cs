using UnityEngine;

public class MoveMiddleStone : MonoBehaviour
{
    public GameObject Stones;
    public float targetY = -46.04f;
    public float moveSpeed = 1f; // Adjust speed as needed
    public bool isMove = false; // Can be accessed from another script

    private void Update()
    {
        if (isMove && Stones != null)
        {
            // Move the stone from current Y position to the target Y
            float newY = Mathf.MoveTowards(Stones.transform.position.y, targetY, moveSpeed * Time.deltaTime);
            Stones.transform.position = new Vector3(Stones.transform.position.x, newY, Stones.transform.position.z);

            // Stop moving when the target is reached
            if (newY == targetY)
            {
                isMove = false; // Stops movement
                enabled = false; // Disables the script once the movement is done
            }
        }
    }
}
