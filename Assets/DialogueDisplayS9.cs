using UnityEngine;

public class DialogueDisplayS9 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8;
    public GameObject I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, I17;
    public GameObject D9, D10, D11;
    public GameObject WrongCanvas, CorrectCanvas1;

    //Q1
    public GameObject DoorLock1, CircleDialogue1, PunchingBag, Scripts1, Magma1, CloseDoor1, OpenDoor1, Option1Script, Option2Script, Option1Canvas, Option2Canvas, Option1, Option2, Magma1Canvas;

    //Q2
    public GameObject DoorLock2, CircleDialogue2, Pot1, Pot2, Char1, Char2, DoorCircle2, Option3Script, Option4Script, Option3Canvas, Option4Canvas, Option3, Option4, Magma2Canvas, Scripts2, CorrectCanvas2, CloseDoor2, OpenDoor2, Char3, DoorCircle3;


    //Q3
    public GameObject DoorLock3, Basket, Scale, Option5Script, Option6Script, Option5Canvas, Option6Canvas, Option5, Option6, Magma3Canvas, Scripts3, CorrectCanvas3, CloseDoor3, OpenDoor3, CircleDialogue3;


    //Q4
    public GameObject Char4, DoorLock4, CircleDialogue4, YesOrNo, Option7, Option8, YesOrYes, NoOrNo, DoorCircle4, magma, CloseDoor4, OpenDoor4, Option9, Option10, Option11, Option12, END, chest, portalToMap;


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

        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        I9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        I12.SetActive(false);
        I13.SetActive(false);
        I14.SetActive(false);
        I15.SetActive(false);
        I16.SetActive(false);
        I17.SetActive(false);

        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);


        //Q1
        CircleDialogue1.SetActive(false);
        PunchingBag.SetActive(false);
        Scripts1.SetActive(false);
        OpenDoor1.SetActive(false);
        DoorLock1.SetActive(false);
        Option1Script.SetActive(false);
        Option2Script.SetActive(false);
        Option1Canvas.SetActive(false);
        Option2Canvas.SetActive(false);
        Option1.SetActive(false);
        Option2.SetActive(false);
        Magma1Canvas.SetActive(false);
        WrongCanvas.SetActive(false);
        CorrectCanvas1.SetActive(false);

        //Q2
        Pot2.SetActive(false);
        Pot1.SetActive(false);
        CircleDialogue2.SetActive(false);
        DoorLock2.SetActive(false);
        Char2.SetActive(false);
        DoorCircle2.SetActive(false);

        Option3Script.SetActive(false);
        Option4Script.SetActive(false);
        Option3Canvas.SetActive(false);
        Option4Canvas.SetActive(false);
        Option3.SetActive(false);
        Option4.SetActive(false);
        Magma2Canvas.SetActive(false);
        Scripts2.SetActive(false);
        OpenDoor2.SetActive(false);
        Char3.SetActive(false);
        DoorCircle3.SetActive(false);

        //Q3

        Basket.SetActive(false);
        Scale.SetActive(false);

        Option5Script.SetActive(false);
        Option6Script.SetActive(false);
        Option5Canvas.SetActive(false);
        Option6Canvas.SetActive(false);
        Option5.SetActive(false);
        Option6.SetActive(false);
        Magma3Canvas.SetActive(false);
        Scripts3.SetActive(false);
        CorrectCanvas3.SetActive(false);
        OpenDoor3.SetActive(false);
        CircleDialogue3.SetActive(false);
        DoorLock3.SetActive(false);

        //Q4
        Char4.SetActive(false);
        DoorLock4.SetActive(false);
        YesOrNo.SetActive(false);
        CircleDialogue4.SetActive(false);
        Option7.SetActive(false);
        Option8.SetActive(false);
        YesOrYes.SetActive(false);
        NoOrNo.SetActive(false);
        DoorCircle4.SetActive(false);
        magma.SetActive(false);
        OpenDoor4.SetActive(false);
        Option9.SetActive(false);
        Option10.SetActive(false);
        Option11.SetActive(false);
        Option12.SetActive(false);
        END.SetActive(false);
        chest.SetActive(false);
        portalToMap.SetActive(false);
    }

    public void ENDClose()
    {
        END.SetActive(false);
        portalToMap.SetActive(true);
    }

    public void Option7Close()
    {
        Option7.SetActive(false);
        YesOrYes.SetActive(true);
    }

    public void Option8Close()
    {
        Option8.SetActive(false);
        NoOrNo.SetActive(true);
    }

    public void Option9Close()
    {
        Option9.SetActive(false);
    }

    public void Option10Close()
    {
        Option10.SetActive(false);
    }

    public void Option11Close()
    {
        Option11.SetActive(false);
    }

    public void Option12Close()
    {
        Option12.SetActive(false);
    }

    public void WrongCanvasClose()
    {
        WrongCanvas.SetActive(false);
    }

    public void CorrectCanvas1Close()
    {
        CorrectCanvas1.SetActive(false);
        CloseDoor1.SetActive(false);
        OpenDoor1.SetActive(true);
        Char1.SetActive(false);
        Char2.SetActive(true);
        DoorCircle2.SetActive(true);
    }

    public void CorrectCanvas2Close()
    {
        CorrectCanvas2.SetActive(false);
        CloseDoor2.SetActive(false);
        OpenDoor2.SetActive(true);
        Char2.SetActive(false);
        Char3.SetActive(true);
        DoorCircle3.SetActive(true);
    }

    public void CorrectCanvas3Close()
    {
        CorrectCanvas3.SetActive(false);
        CloseDoor3.SetActive(false);
        OpenDoor3.SetActive(true);
        Char3.SetActive(false);
        Char4.SetActive(true);
        DoorCircle4.SetActive(true);
    }

    public void CircleDialogue1Show()
    {
        CircleDialogue1.SetActive(true);
        DoorLock1.SetActive(false);
    }

    public void CircleDialogue2Show()
    {
        CircleDialogue2.SetActive(true);
        DoorLock2.SetActive(false);
    }

    public void CircleDialogue3Show()
    {
        CircleDialogue3.SetActive(true);
        DoorLock3.SetActive(false);
    }

    public void CircleDialogue4Show()
    {
        CircleDialogue4.SetActive(true);
        DoorLock4.SetActive(false);
    }

    // Dialogue Show Methods
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
    public void D7Close()
    {
        D7.SetActive(false);
        PunchingBag.SetActive(true);
    }
    public void D8Show()
    {
        ShowDialogue(D8);
    }
    public void D9Show()
    {
        ShowDialogue(D9);
    }

    public void D9Close()
    {
        D9.SetActive(false);
        YesOrNo.SetActive(true);
        magma.SetActive(true);

    }
    public void D10Show()
    {
        ShowDialogue(D10);
    }
    public void D10Close()
    {
        D10.SetActive(false);
    }
    public void D11Show()
    {
        ShowDialogue(D11);
    }

    public void D11Close()
    {
        D11.SetActive(false);
        OpenDoor4.SetActive(true);
        CloseDoor4.SetActive(false);
        chest.SetActive(true);
    }

    // Image Show Methods
    public void I1Show()
    {
        ShowDialogue(I1);
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
        Option1Script.SetActive(true);
        Option2Script.SetActive(true);
        Magma1Canvas.SetActive(true);
    }
    public void Option1Close()
    {
        Option1Canvas.SetActive(true);
        Option1.SetActive(false);
    }

    public void Option2Close()
    {
        Option2Canvas.SetActive(true);
        Option2.SetActive(false);
    }

    public void I4Show()
    {
        ShowDialogue(I4);
    }
    public void I5Show()
    {
        ShowDialogue(I5);
    }
    public void I5Close()
    {
        I5.SetActive(false);
        Pot1.SetActive(true);
        Pot2.SetActive(true);
    }
    public void I6Show()
    {
        ShowDialogue(I6);
    }
    public void I7Show()
    {
        ShowDialogue(I7);
    }
    public void I8Show()
    {
        ShowDialogue(I8);
    }
    public void I9Show()
    {
        ShowDialogue(I9);
    }
    public void I9Close()
    {
        I9.SetActive(false);
        Option3Script.SetActive(true);
        Option4Script.SetActive(true);
        Scripts2.SetActive(true);
        Magma2Canvas.SetActive(true);
    }
    public void Option3Close()
    {
        Option3.SetActive(false);
        Option3Canvas.SetActive(true);
    }
    public void Option4Close()
    {
        Option4.SetActive(false);
        Option4Canvas.SetActive(true);
    }
    public void I10Show()
    {
        ShowDialogue(I10);
    }
    public void I10Close()
    {
        I10.SetActive(false);
        Scale.SetActive(true);
        Basket.SetActive(true);
    }
    public void I11Show()
    {
        ShowDialogue(I11);
    }
    public void I12Show()
    {
        ShowDialogue(I12);
    }
    public void I13Show()
    {
        ShowDialogue(I13);
    }
    public void I14Show()
    {
        ShowDialogue(I14);
    }
    public void I14Close()
    {
        I14.SetActive(false);
        Option5Script.SetActive(true);
        Option6Script.SetActive(true);
        Scripts3.SetActive(true);
        Magma3Canvas.SetActive(true);

    }

    public void Option5Close()
    {
        Option5.SetActive(false);
        Option5Canvas.SetActive(true);
    }
    public void Option6Close()
    {
        Option6.SetActive(false);
        Option6Canvas.SetActive(true);
    }
    public void I15Show()
    {
        ShowDialogue(I15);
    }
    public void I16Show()
    {
        ShowDialogue(I16);
    }
    public void I17Show()
    {
        ShowDialogue(I17);
    }


    private void ShowDialogue(GameObject dialogue)
    {
        // Hide D objects
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

        // Hide I objects
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        I6.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        I9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        I12.SetActive(false);
        I13.SetActive(false);
        I14.SetActive(false);
        I15.SetActive(false);
        I16.SetActive(false);
        I17.SetActive(false);

        // Show selected object
        dialogue.SetActive(true);
    }
}
