using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTransitionToGame : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Scene1"))
        {

            SceneManager.LoadScene("Scene1");
        } else if (collision.gameObject.CompareTag("Scene2"))
        {

            SceneManager.LoadScene("Scene2");
        } else if (collision.gameObject.CompareTag("Scene3"))
        {

            SceneManager.LoadScene("Scene3");
        }
        else if (collision.gameObject.CompareTag("Scene4"))
        {

            SceneManager.LoadScene("Scene4");
        }
        else if (collision.gameObject.CompareTag("Scene5"))
        {

            SceneManager.LoadScene("Scene5");
        }
        else if (collision.gameObject.CompareTag("Scene6"))
        {
            // Log to confirm collision

            SceneManager.LoadScene("Scene6");
        }
        else if (collision.gameObject.CompareTag("Scene7"))
        {

            SceneManager.LoadScene("Scene7");
        }
        else if (collision.gameObject.CompareTag("Scene8"))
        {

            SceneManager.LoadScene("Scene8");
        }
        else if (collision.gameObject.CompareTag("Scene9"))
        {

            SceneManager.LoadScene("Scene9");
        }
    }
}
