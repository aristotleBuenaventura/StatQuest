using UnityEngine;

public class ZtableNextButton : MonoBehaviour
{
    public GameObject front, back;

    public void frontZtable()
    {
        front.SetActive(true);
        back.SetActive(false);
    }

    public void backZtable()
    {
        front.SetActive(false);
        back.SetActive(true);
    }
}
