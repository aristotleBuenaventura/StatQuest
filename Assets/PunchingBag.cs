using UnityEngine;

public class PunchingBag : MonoBehaviour
{
    private int punchCount = 0;
    public GameObject Scripts, PunchingBagCanvas, PunchingBagObject, I2;

    public void Punch()
    {
        punchCount++;
        Debug.Log("Punch count: " + punchCount);

        if (punchCount >= 10)
        {
            Scripts.SetActive(true);
            PunchingBagObject.SetActive(false);
            I2.SetActive(true);
            PunchingBagCanvas.SetActive(false);
            Debug.Log("Done");
        }
    }
}
