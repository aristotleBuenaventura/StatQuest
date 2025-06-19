using UnityEngine;

public class HintShow : MonoBehaviour
{
    public GameObject hints;
    public HintManager hintremove;
    private bool canOpenHint = false; // Controls if OpenHint() can be used
    public GameObject hintsYESORNO;

    public void OpenHint()
    {
        if (canOpenHint)
        {
            hintremove.UseHint();
            hints.SetActive(true);
            hintsYESORNO.SetActive(false);
        }
    }

    public void CloseHint()
    {
        hints.SetActive(false);
    }

    public void EnableOpenHint()
    {
        canOpenHint = true; // Allow OpenHint() to work again
    }
}
