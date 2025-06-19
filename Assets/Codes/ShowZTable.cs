using UnityEngine;

public class ShowZTable : MonoBehaviour
{
    public GameObject ZTable, D9;
    public bool isShow = false;
    public bool isHide = false;

    public void ToggleZTable()
    {
        ZTable.SetActive(!ZTable.activeSelf);

        if (isShow && !isHide)
        {
            D9.SetActive(true);
            isHide=true;
        }
    }
}
