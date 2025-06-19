using UnityEngine;

public class CloseWrongCanvas : MonoBehaviour
{
    public GameObject wrongcanvas;

    public void wrongCanvasClose()
    {
        wrongcanvas.SetActive(false);
    }
}
