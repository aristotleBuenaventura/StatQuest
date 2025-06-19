using UnityEngine;

public class DialogueDisplayS3 : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D6, I7, I8, D9, I10, I11, I112, I12, D13, D14, D15, D16, I18, D19, D21, D23, D25, D27, D28, I29, D30, D31, I32, I33, I34, D35, I36, I37, D39, I41, D42, I43, D44;
    public GameObject Stones, Q1, Q2, Q3, Q4, Q5, Player, Q38, Q40;
    public GameObject Stone1, Stone2, Stone3, Stone4, Stone5, Torch1, Torch2, Torch3, Torch4, Torch5, TorchGame, Bonfire, pebbles;
    public MoveMiddleStone midstone;
    public GameObject Abe, circle;
    public GameObject barricade, portal;
    public GameObject DWomen, Women;

    void Start()
    {
        barricade.SetActive(true);
        portal.SetActive(false);
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D6.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        D9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        I12.SetActive(false);
        D13.SetActive(false);
        D14.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        I18.SetActive(false);
        D19.SetActive(false);
        D21.SetActive(false);
        D23.SetActive(false);
        D25.SetActive(false);
        D27.SetActive(false);
        D28.SetActive(false);
        I29.SetActive(false);
        D30.SetActive(false);
        D31.SetActive(false);
        I32.SetActive(false);
        I33.SetActive(false);
        I34.SetActive(false);
        D35.SetActive(false);
        I36.SetActive(false);
        I37.SetActive(false);
        D39.SetActive(false);
        Q40.SetActive(false);
        I41.SetActive(false);
        D42.SetActive(false);
        I43.SetActive(false);
        D44.SetActive(false);
        Q38.SetActive(false);
        Stones.SetActive(false);
        Abe.SetActive(false);
        circle.SetActive(false);
        I112.SetActive(false);
        DWomen.SetActive(false);
        Women.SetActive(false);
    }

    public void D2Show()
    {
        ShowDialogue(D2);
    }

    public void AbeShow()
    {
        Abe.SetActive(true);
        circle.SetActive(true);
        D2.SetActive(false);
    }

    public void D3Show()
    {
        ShowDialogue(D3);
    }

    public void D4Show()
    {
        ShowDialogue(D4);
    }

    public void D6Show()
    {
        ShowDialogue(D6);
    }

    public void I7Show()
    {
        ShowDialogue(I7);
    }

    public void I8Show()
    {
        ShowDialogue(I8);
    }

    public void D9Show()
    {
        ShowDialogue(D9);
    }

    public void I10Show()
    {
        ShowDialogue(I10);
    }

    public void I11Show()
    {
        ShowDialogue(I11);
    }

    public void I112Show()
    {
        ShowDialogue(I112);
    }

    public void I12Show()
    {
        ShowDialogue(I12);
        Stones.SetActive(true);
    }

    public void D13Show()
    {
        ShowDialogue(D13);
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
        Q1.SetActive(true);
    }

    public void I18Show()
    {
        ShowDialogue(I18);
    }

    public void I18Close()
    {
        I18.SetActive(false);
    }

    public void Q2Show()
    {
        Q1.SetActive(false);
        Q2.SetActive(true);
        Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
        Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
        D19.SetActive(false);
    }

    public void Q3Show()
    {
        Q2.SetActive(false);
        Q3.SetActive(true);
        Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
        Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
        D21.SetActive(false);
    }

    public void Q4Show()
    {
        Q3.SetActive(false);
        Q4.SetActive(true);
        Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
        Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
        D23.SetActive(false);
    }

    public void Q5Show()
    {
        Q4.SetActive(false);
        Q5.SetActive(true);
        Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
        Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
        D25.SetActive(false);
    }

    public void D28Show()
    {
        ShowDialogue(D28);
        Q5.SetActive(false);
        Player.transform.position = new Vector3(32.089f, -2.42f, -54.767f);
        Player.transform.rotation = Quaternion.Euler(0f, -120.161f, 0f);
        D27.SetActive(false);

    }

    public void I29Show()
    {
        ShowDialogue(I29);
        Stone1.SetActive(false);
        Stone2.SetActive(false);
        Stone3.SetActive(false);
        Stone4.SetActive(false);
        Stone5.SetActive(false);
        Torch1.SetActive(true);
        Torch2.SetActive(true);
        Torch3.SetActive(true);
        Torch4.SetActive(true);
        Torch5.SetActive(true);
        Bonfire.SetActive(true);
    }

    public void D30Show()
    {
        ShowDialogue(D30);
    }

    public void D31Show()
    {
        ShowDialogue(D31);
    }

    public void I32Show()
    {
        ShowDialogue(I32);
    }

    public void I32Close()
    {
        I32.SetActive(false);
        TorchGame.SetActive(true);
    }

    public void I33Show()
    {
        ShowDialogue(I33);
    }

    public void I34Show()
    {
        ShowDialogue(I34);
        
    }

    public void D35Show()
    {
        ShowDialogue(D35);
        Stones.SetActive(false);
        Bonfire.SetActive(false);
    }

    public void I36Show()
    {
        ShowDialogue(I36);
    }

    public void I37Show()
    {
        ShowDialogue(I37);
    }

    public void D39Show()
    {
        ShowDialogue(D39);
    }

    public void I41Show()
    {
        ShowDialogue(I41);
    }

    public void D42Show()
    {
        ShowDialogue(D42);
    }

    public void I43Show()
    {
        ShowDialogue(I43);
    }

    public void I43Close()
    {
        I43.SetActive(false);
        barricade.SetActive(false);
        DWomen.SetActive(true);
        Women.SetActive(true);
    }

    public void D44Show()
    {
        ShowDialogue(D44);
    }

    public void D44Close()
    {
        D44.SetActive(false);
        barricade.SetActive(false);

    }

    public void Q38Show()
    {
        ShowDialogue(Q38);
        pebbles.SetActive(true);
        midstone.isMove = true;
    }

    public void Q38Close()
    {
        Q38.SetActive(false);
    }

    public void Q40Show()
    {
        ShowDialogue(Q40);
    }

    public void Q40Close()
    {
        Q40.SetActive(false);
    }

    private void ShowDialogue(GameObject dialogue)
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D6.SetActive(false);
        I7.SetActive(false);
        I8.SetActive(false);
        D9.SetActive(false);
        I10.SetActive(false);
        I11.SetActive(false);
        I12.SetActive(false);
        D13.SetActive(false);
        D14.SetActive(false);
        D15.SetActive(false);
        D16.SetActive(false);
        I18.SetActive(false);
        D19.SetActive(false);
        D21.SetActive(false);
        D23.SetActive(false);
        D25.SetActive(false);
        D27.SetActive(false);
        D28.SetActive(false);
        I29.SetActive(false);
        D30.SetActive(false);
        D31.SetActive(false);
        I32.SetActive(false);
        I33.SetActive(false);
        I34.SetActive(false);
        D35.SetActive(false);
        I36.SetActive(false);
        I37.SetActive(false);
        D39.SetActive(false);
        Q40.SetActive(false);
        I41.SetActive(false);
        D42.SetActive(false);
        I43.SetActive(false);
        D44.SetActive(false);
        Q38.SetActive(false);
        I112.SetActive(false);
        dialogue.SetActive(true);
    }
}