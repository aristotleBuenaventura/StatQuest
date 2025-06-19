using UnityEngine;

public class ScrollAppear : MonoBehaviour
{
    public ScrollChecker material;
    public GameObject ScrollOnHand;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ScrollCorrect") || collision.gameObject.CompareTag("ScrollWrong"))
        {
            ScrollOnHand.SetActive(true);

            if (collision.gameObject.CompareTag("ScrollCorrect"))
            {
                material.SetMaterialName("Correct");
            }
            else if (collision.gameObject.CompareTag("ScrollWrong"))
            {
                material.SetMaterialName("Wrong");
            }

       
        }

    }
}
