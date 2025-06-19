using UnityEngine;

public class DialogueDisplayS7 : MonoBehaviour
{
    public GameObject WrongCanvas, D1, D2, D3, D4, I1, I2, I3, I4, I5, I6, Q1, C1, Q2, C2, D5, I7, I8, Q3, C3, Q4, C4, Q5, C5, Q6, C6, Q7, C7, Q8, C8, Q9, C9, I9, I10, I11, Q10, I12, I13, C10, Q11, I14, C11, Q12, I15, C12, D6;
    public GameObject Balloon1, CanvasQ1, Balloon2, CanvasQ2, Balloon3, CanvasQ3, Balloon4, CanvasQ4, Balloon5, CanvasQ5, Balloon6, CanvasQ6, Balloon7, CanvasQ7, Balloon8, CanvasQ8, Balloon9, CanvasQ9, Balloon10, CanvasQ10;
    public GameObject Balloon11, CanvasQ11, Balloon12, CanvasQ12, Portal, DialogueDisplay2;


    void Start()
    {
        WrongCanvas.SetActive(false);
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        Q1.SetActive(false);
        C1.SetActive(false);
        Q2.SetActive(false);
        C2.SetActive(false);
        D5.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        Q3.SetActive(false);
        C3.SetActive(false);
        Q4.SetActive(false);
        C4.SetActive(false);
        Q5.SetActive(false);
        C5.SetActive(false);
        Q6.SetActive(false);
        C6.SetActive(false);
        Q7.SetActive(false);
        C7.SetActive(false);
        Q8.SetActive(false);
        C8.SetActive(false);
        Q9.SetActive(false);
        C9.SetActive(false);
        I9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        Q10.SetActive(false);
        I12.SetActive(false);
        I13.SetActive(false);
        C10.SetActive(false);
        Q11.SetActive(false);
        I14.SetActive(false);
        C11.SetActive(false);
        Q12.SetActive(false);
        I15.SetActive(false);
        C12.SetActive(false);
        D6.SetActive(false);

        Balloon1.SetActive(false);
        CanvasQ1.SetActive(false);

        Balloon2.SetActive(false);
        CanvasQ2.SetActive(false);

        Balloon3.SetActive(false);
        CanvasQ3.SetActive(false);

        Balloon4.SetActive(false);
        CanvasQ4.SetActive(false);

        Balloon5.SetActive(false);
        CanvasQ5.SetActive(false);

        Balloon6.SetActive(false);
        CanvasQ6.SetActive(false);

        Balloon7.SetActive(false);
        CanvasQ7.SetActive(false);

        Balloon8.SetActive(false);
        CanvasQ8.SetActive(false);

        Balloon9.SetActive(false);
        CanvasQ9.SetActive(false);

        Balloon10.SetActive(false);
        CanvasQ10.SetActive(false);

        Balloon11.SetActive(false);
        CanvasQ11.SetActive(false);

        Balloon12.SetActive(false);
        CanvasQ12.SetActive(false);

        Portal.SetActive(false);
        DialogueDisplay2.SetActive(false);
    }

    public void WrongCanvasClose()
    {
        WrongCanvas.SetActive(false);
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

    public void I1Show()
    {
        ShowDialogue(I1);
    }

    public void I2Show()
    {
        ShowDialogue(I2);
    }

    public void I2Close()
    {
        I2.SetActive(false);
        CanvasQ1.SetActive(true);
    }

    public void I3Show()
    {
        ShowDialogue(I3);
    }

    public void I4Show()
    {
        ShowDialogue(I4);
    }

    public void I5Show()
    {
        ShowDialogue(I5);
    }

    public void I6Show()
    {
        ShowDialogue(I6);
    }

    public void Q1Show()
    {
        ShowDialogue(Q1);
    }

    public void Q1Close()
    {
        Q1.SetActive(false);
        Balloon1.SetActive(true);
    }

    public void C1Show()
    {
        ShowDialogue(C1);
    }

    public void C1Close()
    {
        C1.SetActive(false);
        Balloon1.SetActive(false);
        CanvasQ2.SetActive(true);
    }

    public void Q2Show()
    {
        ShowDialogue(Q2);
    }

    public void Q2Close()
    {
        Q2.SetActive(false);
        Balloon2.SetActive(true);
    }

    public void C2Show()
    {
        ShowDialogue(C2);
    }

    public void C2Close()
    {
        C2.SetActive(false);
        Balloon2.SetActive(false);
        DialogueDisplay2.SetActive(true);
    }

    public void D5Show()
    {
        ShowDialogue(D5);
    }

    public void D5Close()
    {
        D5.SetActive(false);
        CanvasQ3.SetActive(true);
    }

    public void I7Show()
    {
        ShowDialogue(I7);
    }

    public void I8Show()
    {
        ShowDialogue(I8);
    }

    public void Q3Show()
    {
        ShowDialogue(Q3);
    }

    public void Q3Close()
    {
        Q3.SetActive(false);
        Balloon3.SetActive(true);
    }

    public void C3Show()
    {
        ShowDialogue(C3);
    }

    public void C3Close()
    {
        C3.SetActive(false);
        Balloon3.SetActive(false);
        CanvasQ4.SetActive(true);
    }

    public void Q4Show()
    {
        ShowDialogue(Q4);
    }

    public void Q4Close()
    {
        Q4.SetActive(false);
        Balloon4.SetActive(true);

    }

    public void C4Show()
    {
        ShowDialogue(C4);
    }

    public void C4Close()
    {
        C4.SetActive(false);
        Balloon4.SetActive(false);
        CanvasQ5.SetActive(true);
    }

    public void Q5Show()
    {
        ShowDialogue(Q5);
    }

    public void Q5Close()
    {
        Q5.SetActive(false);
        Balloon5.SetActive(true);
    }

    public void C5Show()
    {
        ShowDialogue(C5);
    }

    public void C5Close()
    {
        C5.SetActive(false);
        Balloon5.SetActive(false);
        CanvasQ6.SetActive(true);
    }

    public void Q6Show()
    {
        ShowDialogue(Q6);
    }

    public void Q6Close()
    {
        Q6.SetActive(false);
        Balloon6.SetActive(true);
    }

    public void C6Show()
    {
        ShowDialogue(C6);
    }

    public void C6Close()
    {
        C6.SetActive(false);
        Balloon6.SetActive(false);
        CanvasQ7.SetActive(true);
    }


    public void Q7Show()
    {
        ShowDialogue(Q7);
    }

    public void Q7Close()
    {
        Q7.SetActive(false);
        Balloon7.SetActive(true);

    }

    public void C7Show()
    {
        ShowDialogue(C7);
    }

    public void C7Close()
    {
        C7.SetActive(false);
        Balloon7.SetActive(false);
        CanvasQ8.SetActive(true);
    }

    public void Q8Show()
    {
        ShowDialogue(Q8);
    }

    public void Q8Close()
    {
        Q8.SetActive(false);
        Balloon8.SetActive(true);
    }

    public void C8Show()
    {
        ShowDialogue(C8);
    }

    public void C8Close()
    {
        C8.SetActive(false);
        Balloon8.SetActive(false);
        CanvasQ9.SetActive(true);
    }

    public void Q9Show()
    {
        ShowDialogue(Q9);
    }

    public void Q9Close()
    {
        Q9.SetActive(false);
        Balloon9.SetActive(true);
    }

    public void C9Show()
    {
        ShowDialogue(C9);
    }

    public void C9Close()
    {
        C9.SetActive(false);
        Balloon9.SetActive(false);
        CanvasQ10.SetActive(true);
    }

    public void I9Show()
    {
        ShowDialogue(I9);
    }

    public void I10Show()
    {
        ShowDialogue(I10);
    }

    public void I11Show()
    {
        ShowDialogue(I11);
    }

    public void Q10Show()
    {
        ShowDialogue(Q10);
    }

    public void I12Show()
    {
        ShowDialogue(I12);
    }

    public void I13Show()
    {
        ShowDialogue(I13);
    }

    public void I13Close()
    {
        I13.SetActive(false);
        Balloon10.SetActive(true);
    }

    public void C10Show()
    {
        ShowDialogue(C10);
    }

    public void C10Close()
    {
        C10.SetActive(false);
        Balloon10.SetActive(false);
        CanvasQ11.SetActive(true);
    }

    public void Q11Show()
    {
        ShowDialogue(Q11);
    }

    public void I14Show()
    {
        ShowDialogue(I14);
    }

    public void I14Close()
    {
        I14.SetActive(false);
        Balloon11.SetActive(true);
    }

    public void C11Show()
    {
        ShowDialogue(C11);
    }

    public void C11Close()
    {
        C11.SetActive(false);
        Balloon11.SetActive(false);
        CanvasQ12.SetActive(true);
    }

    public void Q12Show()
    {
        ShowDialogue(Q12);
    }

    public void I15Show()
    {
        ShowDialogue(I15);
    }

    public void I15Close()
    {
        I15.SetActive(false);
        Balloon12.SetActive(true);
    }

    public void C12Show()
    {
        ShowDialogue(C12);
    }

    public void D6Show()
    {
        ShowDialogue(D6);
    }

    public void D6Close()
    {
        D6.SetActive(false);
        Balloon12.SetActive(false);
        Portal.SetActive(true);
    }

    private void ShowDialogue(GameObject dialogue)
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        Q1.SetActive(false);
        C1.SetActive(false);
        Q2.SetActive(false);
        C2.SetActive(false);
        D5.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        Q3.SetActive(false);
        C3.SetActive(false);
        Q4.SetActive(false);
        C4.SetActive(false);
        Q5.SetActive(false);
        C5.SetActive(false);
        Q6.SetActive(false);
        C6.SetActive(false);
        Q7.SetActive(false);
        C7.SetActive(false);
        Q8.SetActive(false);
        C8.SetActive(false);
        Q9.SetActive(false);
        C9.SetActive(false);
        I9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        Q10.SetActive(false);
        I12.SetActive(false);
        I13.SetActive(false);
        C10.SetActive(false);
        Q11.SetActive(false);
        I14.SetActive(false);
        C11.SetActive(false);
        Q12.SetActive(false);
        I15.SetActive(false);
        C12.SetActive(false);
        D6.SetActive(false);

        dialogue.SetActive(true);
    }
}
