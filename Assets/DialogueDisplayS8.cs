using UnityEngine;

public class DialogueDisplayS8 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, I1, I2, I3, I4, I5, Q1, C1, Q2, C2, Q3, C3, circle1, post1, script1;
    public GameObject woods, plywoods, roofs, wrongcanvas, q1Circle, correctcanvas, q2Cirlce, q3Cirlce, portalAlien, Aliens, portal, dialogueAlien;

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
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        Q1.SetActive(false);
        C1.SetActive(false);
        Q2.SetActive(false);
        C2.SetActive(false);
        Q3.SetActive(false);
        C3.SetActive(false);
        circle1.SetActive(false);
        post1.SetActive(false);
        script1.SetActive(false);
        woods.SetActive(false);
        roofs.SetActive(false);
        plywoods.SetActive(false);
        wrongcanvas.SetActive(false);
        correctcanvas.SetActive(false);
        q2Cirlce.SetActive(false);
        q3Cirlce.SetActive(false);
        portalAlien.SetActive(false);
        Aliens.SetActive(false);
        portal.SetActive(false);
        dialogueAlien.SetActive(false);
    }
    public void wrongClose()
    {
        wrongcanvas.SetActive(false);
    }
    public void correctClose()
    {
        correctcanvas.SetActive(false);
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

    public void D7Close()
    {
        D7.SetActive(false);
        circle1.SetActive(true);
        post1.SetActive(true);
        script1.SetActive(true);
    }

    public void D8Show()
    {
        ShowDialogue(D8);
        
    }
    public void D9Show()
    {
        ShowDialogue(D9);
        portalAlien.SetActive(true);
        
    }
    public void D10Show()
    {
        ShowDialogue(D10);
        Aliens.SetActive(true);
    }

    public void D10Close()
    {
        D10.SetActive(false);
        portal.SetActive(true);
    }

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
        script1.SetActive(false);
        q1Circle.SetActive(true);
    }

    public void I4Show()
    {
        ShowDialogue(I4);
    }
    public void I5Show()
    {
        ShowDialogue(I5);
    }
    public void Q1Show()
    {
        ShowDialogue(Q1);
    }

    public void Q1Close()
    {
        Q1.SetActive(false);
        woods.SetActive(true);
    }
    public void C1Show()
    {
        ShowDialogue(C1);
    }

    public void C1Close()
    {
        C1.SetActive(false);
        q2Cirlce.SetActive(true);
    }
    public void Q2Show()
    {
        ShowDialogue(Q2);
    }

    public void Q2Close()
    {
        Q2.SetActive(false);
        plywoods.SetActive(true);
    }

    public void C2Show()
    {
        ShowDialogue(C2);
    }

    public void C2Close()
    {
        C2.SetActive(false);
        q3Cirlce.SetActive(true);
    }

    public void Q3Show()
    {
        ShowDialogue(Q3);
    }

    public void Q3Close()
    {
        Q3.SetActive(false);
        roofs.SetActive(true);
    }

    public void C3Show()
    {
        ShowDialogue(C3);
    }

    public void C3Close()
    {
        C3.SetActive(false);
        dialogueAlien.SetActive(true);
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
        I1.SetActive(false);
        I2.SetActive(false);
        I3.SetActive(false);
        I4.SetActive(false);
        I5.SetActive(false);
        Q1.SetActive(false);
        C1.SetActive(false);
        Q2.SetActive(false);
        C2.SetActive(false);
        Q3.SetActive(false);
        C3.SetActive(false);

        dialogue.SetActive(true);
    }
}
