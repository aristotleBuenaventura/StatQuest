using UnityEngine;

public class DialogueDisplayS6 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, I1, I2, I3, I4, I5, I6, I7;
    public GameObject A1, A2, circleFish, circle3, Q1, Q1Canvas, circle4, A3, A4, circle5, circle6, Q2, Q2Canvas, A5, A6, circle7, circle8, circle9, Q3, Q3Canvas;
    public GameObject D15, D16, D17, D18, portal, portalStone, Wrong1, Wrong2, Wrong3;
    public ChangeBaseColor Color1, Color2, Color3;
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
        D14.SetActive(false);
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        I7.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        D17.SetActive(false);
        D18.SetActive(false);

        A1.SetActive(false);
        A2.SetActive(false);
        circleFish.SetActive(false);
        circle3.SetActive(false);
        Q1.SetActive(false);
        Q1Canvas.SetActive(true);
        circle4.SetActive(false);

        A3.SetActive(false);
        A4.SetActive(false);
        circle5.SetActive(false);
        circle6.SetActive(false);
        Q2.SetActive(false);
        Q2Canvas.SetActive(true);

        A5.SetActive(false);
        A6.SetActive(false);
        circle7.SetActive(false);
        circle8.SetActive(false);
        circle9.SetActive(false);
        Q3.SetActive(false);
        Q3Canvas.SetActive(true);
        portalStone.SetActive(false);
    }

    public void D1Show()
    {
        ShowDialogue(D1);
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

    public void A1Show()
    {
        ShowDialogue(A1);
        circleFish.SetActive(true);
    }

    public void A1Close()
    {
        A1.SetActive(false);
    }

    public void A2Show()
    {
        ShowDialogue(A2);
        
    }

    public void A2Close()
    {
        A2.SetActive(false);
        
    }

    public void A3Close()
    {
        A3.SetActive(false);
        circle5.SetActive(true);
    }

    public void A4Close()
    {
        A4.SetActive(false);
    }

    public void D8Show()
    {
        ShowDialogue(D8);
    }

    public void D9Show()
    {
        ShowDialogue(D9);
    }

    public void D10Show()
    {
        ShowDialogue(D10);
    }

    public void D10Close()
    {
        D10.SetActive(false);
        Q1Canvas.SetActive(false);
        circle4.SetActive(true);
        Wrong1.SetActive(false);
        Color1.SetBaseColor("#fffb03");
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

    public void D14Show()
    {
        ShowDialogue(D14);
    }

    public void D14Close()
    {
        D14.SetActive(false);
        Q2Canvas.SetActive(false);
        circle7.SetActive(true);
        Wrong2.SetActive(false);
        Color2.SetBaseColor("#fffb03");
    }

    public void A5Close()
    {
        A5.SetActive(false);
        circle8.SetActive(true);
    }

    public void A6Close()
    {
        A6.SetActive(false);
        
    }

    public void I1Show()
    {
        ShowDialogue(I1);
    }

    public void I1Close()
    {
        I1.SetActive(false);
        circle3.SetActive(true);

    }

    public void I2Show()
    {
        ShowDialogue(I2);
    }

    public void I3Show()
    {
        ShowDialogue(I3);
    }

    public void I3Close()
    {
        I3.SetActive(false);
        Q1.SetActive(true);
    }

    public void I4Show()
    {
        ShowDialogue(I4);
    }

    public void I4Close()
    {
        I4.SetActive(false);
        circle6.SetActive(true);
    }

    public void I5Show()
    {
        ShowDialogue(I5);
    }

    public void I5Close()
    {
        I5.SetActive(false);
        Q2.SetActive(true);
    }

    public void I6Show()
    {
        ShowDialogue(I6);
    }

    public void I6Close()
    {
        circle9.SetActive(true);
        I6.SetActive(false);
        circle9.SetActive(true);
    }

    public void D15Show()
    {
        ShowDialogue(D15);
    }

    public void D16Show()
    {
        ShowDialogue(D16);
    }

    public void D17Show()
    {
        ShowDialogue(D17);
    }

    public void I7Show()
    {
        ShowDialogue(I7);
    }

    public void I7close()
    {
        I7.SetActive(false);
        Q3.SetActive(true);
    }

    public void D18close()
    {
        D18.SetActive(false);
        portal.SetActive(true);
        portalStone.SetActive(true);
        Wrong3.SetActive(false);
        Color3.SetBaseColor("#fffb03");
    }

    private void ShowDialogue(GameObject dialogue)
    {
        // Disable all dialogues
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
        D14.SetActive(false);
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        I7.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        D17.SetActive(false);
        D18.SetActive(false);

        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);

        // Show the requested dialogue
        dialogue.SetActive(true);
    }
}
