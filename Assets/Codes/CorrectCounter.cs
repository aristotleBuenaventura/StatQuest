using UnityEngine;

public class CorrectCounter : MonoBehaviour
{
    private int counter = 0;
    //public GameObject I33;
    public GameObject Player;
    public GameObject I33;
    public void Increment()
    {
        counter++;
        Debug.Log(counter);
        if (counter == 5)
        {
            //I33.SetActive(true);
            Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
            Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
            I33.SetActive(true);
            Debug.Log(counter);
        }
    }
}