using UnityEngine;

public class DialogueDisplayS4 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, ScrollCanvas, ScrollCanvasFirst, ScrollCanvasSecond, ScollCanvasThird, Challenge1, DragCanvas, D10, C1Choices, C1Wrong, C1Correct, C1Option2;
    public GameObject Scroll1, Scroll2, Scroll3, ScrollNextButton, Challenge1Circle, Challenge2Circle, D11, D12, DragCanvas2, D13, C2Choices, C2Wrong, C2Correct, C2Option2, C3Choices, C3Wrong, C3Correct, C3Option2;
    public GameObject D14, C4Choices, C4Wrong, C4Correct, C4Option2, D15, D16, Challenge2, D17, D18, C5Choices, C5Correct, C5wrong, C5Option2, C6Choices, CanFlip, C6wrong, C6Option2, C6Option3, C7Choices, C7wrong, C7Option1, C7Option2, D19, D20;
    public bool s1, s2, s3;
    public OwlFollowPlayer owl;
    public GameObject portal;
    public ScoreManager score;
    public ProgressBar percent;

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
        ScrollCanvas.SetActive(false);
        ScrollCanvasFirst.SetActive(false);
        ScrollCanvasSecond.SetActive(false);
        ScollCanvasThird.SetActive(false);
        Challenge1.SetActive(false);
        DragCanvas.SetActive(false);
        ScrollNextButton.SetActive(false);
        Challenge1Circle.SetActive(false);
        Challenge2Circle.SetActive(false);
        D10.SetActive(false);
        C1Choices.SetActive(false);
        C1Wrong.SetActive(false);
        C1Correct.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        DragCanvas2.SetActive(false);
        D13.SetActive(false);
        C2Choices.SetActive(false);
        C2Wrong.SetActive(false);
        C2Correct.SetActive(false);
        C3Choices.SetActive(false);
        C3Wrong.SetActive(false);
        C3Correct.SetActive(false);
        C4Choices.SetActive(false);
        C4Wrong.SetActive(false);
        C4Correct.SetActive(false);
        D14.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        Challenge2.SetActive(false);
        D17.SetActive(false);
        D18.SetActive(false);
        C5Choices.SetActive(false);
        C5Correct.SetActive(false);
        C6Choices.SetActive(false);
        C5wrong.SetActive(false);
        CanFlip.SetActive(false);
        C6wrong.SetActive(false);
        C7Choices.SetActive(false);
        D19.SetActive(false);
        D20.SetActive(false);
        portal.SetActive(false);
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

    public void D9Show()
    {
        ShowDialogue(D9);
    }

    public void D9Close()
    {
        D9.SetActive(false);
        owl.canFollow = true;
        Challenge1Circle.SetActive(true);
    }

    public void ScrollCanvasShow()
    {
        ShowDialogue(ScrollCanvas);
    }

    public void ScrollCanvasFirstShow()
    {
        ScrollCanvasFirst.SetActive(true);
        Scroll1.SetActive(false);
        s1 = true;
        CheckScrollCompletion();
    }

    public void ScrollCanvasFirstClose()
    {
        ScrollCanvasFirst.SetActive(false);
    }

    public void ScrollCanvasSecondShow()
    {
        ScrollCanvasSecond.SetActive(true);
        Scroll2.SetActive(false);
        s2 = true;
        CheckScrollCompletion();
    }

    public void ScrollCanvasSecondClose()
    {
        ScrollCanvasSecond.SetActive(false);
    }

    public void ScrollCanvasThirdShow()
    {
        ScollCanvasThird.SetActive(true);
        Scroll3.SetActive(false);
        s3 = true;
        CheckScrollCompletion();
    }

    public void ScrollCanvasThirdClose()
    {
        ScollCanvasThird.SetActive(false);
    }

    public void Challenge1Show()
    {
        ShowDialogue(Challenge1);
    }

    public void D10Show()
    {
        ShowDialogue(D10);
    }

    public void C1ChoicesShow()
    {
        ShowDialogue(C1Choices);
    }

    public void C1WrongShow()
    {
        C1Wrong.SetActive(true);
        score.DecrementScore(3);
    }

    public void C1WrongClose()
    {
        C1Wrong.SetActive(false);
        C1Option2.SetActive(false);
    }

    public void C1CorrectShow()
    {
        ShowDialogue(C1Correct);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void DragCanvasShow()
    {
        ShowDialogue(DragCanvas);
    }

    public void D11Show()
    {
        ShowDialogue(D11);
    }

    public void D12Show()
    {
        ShowDialogue(D12);
    }

    public void DragCanvas2Show()
    {
        ShowDialogue(DragCanvas2);
    }

    public void D13Show()
    {
        ShowDialogue(D13);
    }

    public void C2ChoicesShow()
    {
        ShowDialogue(C2Choices);
    }

    public void C2WrongShow()
    {
        C2Wrong.SetActive(true);
        score.DecrementScore(3);
    }

    public void C2WrongClose()
    {
        C2Wrong.SetActive(false);
        C2Option2.SetActive(false);

    }

    public void C2CorrectShow()
    {
        ShowDialogue(C2Correct);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void C3ChoicesShow()
    {
        ShowDialogue(C3Choices);
    }

    public void C3WrongShow()
    {
        C3Wrong.SetActive(true);
        score.DecrementScore(3);
    }

    public void C3WrongClose()
    {
        C3Wrong.SetActive(false);
        C3Option2.SetActive(false);
        
    }

    public void C3CorrectShow()
    {
        ShowDialogue(C3Correct);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void C4ChoicesShow()
    {
        ShowDialogue(C4Choices);
    }

    public void C4WrongShow()
    {
        C4Wrong.SetActive(true);
        score.DecrementScore(3);
    }

    public void C4WrongClose()
    {
        C4Wrong.SetActive(false);
        C4Option2.SetActive(false);
        
    }

    public void C4CorrectShow()
    {
        ShowDialogue(C4Correct);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void D14Show()
    {
        ShowDialogue(D14);
    }

    public void D15Show()
    {
        ShowDialogue(D15);
    }

    public void D16Show()
    {
        ShowDialogue(D16);
    }

    public void D16Close()
    {
        D16.SetActive(false);
        Challenge2Circle.SetActive(true);
    }

    public void Challenge2Show()
    {
        ShowDialogue(Challenge2);
    }

    public void D17Show()
    {
        ShowDialogue(D17);
    }

    public void D18Show()
    {
        ShowDialogue(D18);
    }

    public void CanFlipShow()
    {
        ShowDialogue(CanFlip);
    }

    public void C5ChoicesShow()
    {
        ShowDialogue(C5Choices);
    }

    public void C5WrongShow()
    {
        C5wrong.SetActive(true);
        C5Option2.SetActive(false);
        score.DecrementScore(5);
    }

    public void C5WrongClose()
    {
        C5wrong.SetActive(false);
        C5Option2.SetActive(false);
    }

    public void C5CorrectShow()
    {
        ShowDialogue(C5Correct);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void C6ChoicesShow()
    {
        ShowDialogue(C6Choices);
    }

    public void C6WrongShow2()
    {
        C6wrong.SetActive(true);
        C6Option2.SetActive(false);
        score.DecrementScore(2);
    }

    public void C6WrongShow3()
    {
        C6wrong.SetActive(true);
        C6Option3.SetActive(false);
        score.DecrementScore(2);
    }

    public void C6CorrectShow()
    {
        ShowDialogue(CanFlip);
        score.IncrementScore(5);
        percent.IncrementProgress(10);
    }

    public void C7ChoicesShow()
    {
        ShowDialogue(C7Choices);
    }

    public void C7WrongShow1()
    {
        C7wrong.SetActive(true);
        C7Option1.SetActive(false);
        score.DecrementScore(2);
    }

    public void C7WrongShow2()
    {
        C7wrong.SetActive(true);
        C7Option2.SetActive(false);
        score.DecrementScore(2);
    }

    public void C7CorrectShow()
    {
        ShowDialogue(CanFlip);
        score.IncrementScore(5);
        percent.IncrementProgress(20);
    }


    public void D20Close()
    {
        D20.SetActive(false);
        portal.SetActive(true);
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
        ScrollCanvas.SetActive(false);
        ScrollCanvasFirst.SetActive(false);
        ScrollCanvasSecond.SetActive(false);
        ScollCanvasThird.SetActive(false);
        Challenge1.SetActive(false);
        DragCanvas.SetActive(false);
        D10.SetActive(false);
        C1Choices.SetActive(false);
        C1Wrong.SetActive(false);
        C1Correct.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        DragCanvas2.SetActive(false);
        D13.SetActive(false);
        C2Choices.SetActive(false);
        C2Wrong.SetActive(false);
        C2Correct.SetActive(false);
        C3Choices.SetActive(false);
        C3Wrong.SetActive(false);
        C3Correct.SetActive(false);
        C4Choices.SetActive(false);
        C4Wrong.SetActive(false);
        C4Correct.SetActive(false);
        D14.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        Challenge2.SetActive(false);
        D17.SetActive(false);
        D18.SetActive(false);
        C5Choices.SetActive(false);
        C5Correct.SetActive(false);
        C6Choices.SetActive(false);
        C5wrong.SetActive(false);
        CanFlip.SetActive(false);
        C6wrong.SetActive(false);
        C7Choices.SetActive(false);
        D19.SetActive(false);
        D20.SetActive(false);
        // Show the requested dialogue
        dialogue.SetActive(true);
    }

    private void CheckScrollCompletion()
    {
        if (s1 && s2 && s3)
        {
            ScrollNextButton.SetActive(true);
        }
    }
}
