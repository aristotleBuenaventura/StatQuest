using UnityEngine;

public class CorrectScrollAppear : MonoBehaviour
{
    public ScrollChecker material;
    public GameObject ScrollOnHand;
    public string material1, material2;
    public GameObject correctScroll, wrongScroll, wrongCanvas, correctCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (material.MaterialName == material1 || material.MaterialName == material2)
            {
                if (material.MaterialName == material1)
                {
                    material.SetMaterialName("STOP");
                    ScrollOnHand.SetActive(false);
                    correctCanvas.SetActive(true);
                    correctScroll.SetActive(true);

                    wrongScroll.SetActive(false);
                    wrongCanvas.SetActive(false);
                }
                else if (material.MaterialName == material2)
                {
                    material.SetMaterialName("STOP");
                    correctCanvas.SetActive(false);
                    correctScroll.SetActive(false);
                    ScrollOnHand.SetActive(false);
                    wrongScroll.SetActive(true);
                    wrongCanvas.SetActive(true);

                }
            }

        }
    }

}
