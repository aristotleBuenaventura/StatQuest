using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
