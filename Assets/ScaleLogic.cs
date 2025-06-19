using UnityEngine;

public class ScaleLogic : MonoBehaviour
{
    public GameObject[] objectsToEnable;
    public GameObject[] objectsToDisable;
    public bool isAllow = false;
    private int currentIndex = 0;
    public BasketLogic basket;
    public GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isAllow && currentIndex < objectsToEnable.Length)
        {
            // Enable current object
            if (objectsToEnable[currentIndex] != null)
            {
                objectsToEnable[currentIndex].SetActive(true);
            }

            // Disable corresponding object, if available
            if (currentIndex < objectsToDisable.Length && objectsToDisable[currentIndex] != null)
            {
                objectsToDisable[currentIndex].SetActive(false);
            }

            currentIndex++;
            isAllow = false; // Block further activations until allowed again

            if (basket != null)
            {
                basket.SetAllow(true); // Enable the basket logic again
            }

            // If all objects are now enabled
            if (currentIndex >= objectsToEnable.Length)
            {
                Canvas.SetActive(true);
                Debug.Log("DONE");
            }
        }
    }

    public void SetAllow(bool value)
    {
        isAllow = value;
    }
}
