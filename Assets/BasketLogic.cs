using UnityEngine;

public class BasketLogic : MonoBehaviour
{
    public GameObject[] objectsToDisable;
    public GameObject[] objectsToEnable;
    public bool isAllow = true;
    private int currentIndex = 0;
    public ScaleLogic scale;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isAllow && currentIndex < objectsToDisable.Length)
        {
            // Disable current object
            if (objectsToDisable[currentIndex] != null)
            {
                objectsToDisable[currentIndex].SetActive(false);
            }

            // Enable corresponding object, if available
            if (currentIndex < objectsToEnable.Length && objectsToEnable[currentIndex] != null)
            {
                objectsToEnable[currentIndex].SetActive(true);
            }

            currentIndex++;
            isAllow = false; // Block further deactivations until allowed again

            if (scale != null)
            {
                scale.SetAllow(true); // Enable the other script's logic if assigned
            }
        }
    }

    public void SetAllow(bool value)
    {
        isAllow = value;
    }
}
