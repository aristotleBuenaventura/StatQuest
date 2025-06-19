using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public GameObject ChestCloseCap, ChestOpenCap;
    private bool hasCollided = false;
    public GameObject Canvas;


    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            
            ChestOpenCap.SetActive(true);
            Canvas.SetActive(true);
            ChestCloseCap.SetActive(false);

        }
    }
}
