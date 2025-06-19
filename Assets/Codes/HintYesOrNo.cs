using UnityEngine;

public class HintYesOrNo : MonoBehaviour
{
    public GameObject hints;    

    public void CloseHint()
    {
        hints.SetActive(false);
    }

    public void OpenHint()
    {
        hints.SetActive(true);
    }
}
