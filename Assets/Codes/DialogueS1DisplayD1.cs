using UnityEngine;

public class DialogueS1DisplayD1 : MonoBehaviour
{
    public GameObject D1;
    private bool hasCollided = false;
    public GameObject circle;
    

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            D1.SetActive(true);
            
            circle.SetActive(false);
           
        }
    }
}
