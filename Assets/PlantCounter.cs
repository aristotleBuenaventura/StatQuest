using UnityEngine;

public class PlantCounter : MonoBehaviour
{

    public int counter = 0;
    public GameObject canvas;

    public void Increment()
    {
        counter++;
        if (counter == 2)
        {
            canvas.SetActive(true);
        }

    }
}
