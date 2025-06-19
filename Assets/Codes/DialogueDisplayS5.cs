using UnityEngine;

public class DialogueDisplayS5 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, Q1, Q2, Q3, Ztable, GameItems;
    public ShowZTable ZTableShow;
    public GameObject circle1, circle2, circle3, Portal;
    public GameObject Option1, Option2, Option3;

    void Start()
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D5.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        D13.SetActive(false);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Ztable.SetActive(false);
        GameItems.SetActive(false);
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        Portal.SetActive(false);
        Option1.SetActive(false);
        Option2.SetActive(false);
        Option3.SetActive(false);
    }

    public void D2Show()
    {
        ShowDialogue(D2);
    }

    public void D3Show()
    {
        ShowDialogue(D3);
    }

    public void D4Show()
    {
        ShowDialogue(D4);
    }

    public void D5Show()
    {
        ShowDialogue(D5);
    }

    public void D6Show()
    {
        ShowDialogue(D6);
    }

    public void D7Show()
    {
        ShowDialogue(D7);
    }

    public void D8Show()
    {
        ShowDialogue(D8);
    }

    public void D8Close()
    {
        D8.SetActive(false);
        ZTableShow.ToggleZTable();
        ZTableShow.isShow = true;
        GameItems.SetActive(true);
    }

    public void D9Show()
    {
        ShowDialogue(D9);
    }

    public void D10Show()
    {
        ShowDialogue(D10);
    }

    public void D11Show()
    {
        ShowDialogue(D11);
    }

    public void D12Show()
    {
        ShowDialogue(D12);
    }

    public void D13Show()
    {
        ShowDialogue(D13);
    }

    public void D13Close()
    {
        GameItems.SetActive(false);
        Portal.SetActive(true);
        D13.SetActive(false);
    }

    public void Q1Show()
    {
        ShowDialogue(Q1);
    }

    public void Q1Close()
    {
        Q1.SetActive(false);
        circle1.SetActive(true);
        Option1.SetActive(true);
    }

    public void Q2Show()
    {
        ShowDialogue(Q2);
    }

    public void Q2Close()
    {
        Q2.SetActive(false);
        circle2.SetActive(true);
        Option1.SetActive(false);
        Option2.SetActive(true);
    }

    public void Q3Show()
    {
        ShowDialogue(Q3);
    }

    public void Q3Close()
    {
        Q3.SetActive(false);
        circle3.SetActive(true);
        Option1.SetActive(false);
        Option2.SetActive(false);
        Option3.SetActive(true);
    }



    private void ShowDialogue(GameObject dialogue)
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D5.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        D13.SetActive(false);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Ztable.SetActive(false);

        dialogue.SetActive(true);
    }
}