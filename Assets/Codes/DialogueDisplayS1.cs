using UnityEngine;

public class DialogueDisplay : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, D10;
    public GameObject Q1Options, Q2Options, Q3Options, CoinFlip, Portal, H1, H2, H3;
    public CoinFlipper coin;
    public HintManager HintEnable;
    public HintShow HintButtonEnable;
    
    private bool hasShownD2, hasShownD3, hasShownD4, hasShownD5, hasShownD6, hasShownD7, hasShownD8, hasShownD9, hasShownD10;
    private bool hasShownQ1, hasShownQ2, hasShownQ3, hasShownCoinFlip;

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
        CoinFlip.SetActive(false);
        Q1Options.SetActive(false);
        Q2Options.SetActive(false);
        Q3Options.SetActive(false);
    }

    public void D2Show()
    {
        if (hasShownD2) return;
        hasShownD2 = true;
        ShowDialogue(D2);
    }

    public void D3Show()
    {
        if (hasShownD3) return;
        hasShownD3 = true;
        ShowDialogue(D3);
    }

    public void D4Show()
    {
        if (hasShownD4) return;
        hasShownD4 = true;
        ShowDialogue(D4);
    }

    public void CoinFlipShow()
    {
        if (hasShownCoinFlip) return;
        hasShownCoinFlip = true;
        ShowDialogue(CoinFlip);
        coin.SetMaxFlips(4);
    }

    public void D5Show()
    {
        if (hasShownD5) return;
        hasShownD5 = true;
        ShowDialogue(D5);
    }

    public void Q1Show()
    {
        if (hasShownQ1) return;
        hasShownQ1 = true;
        ShowDialogue(Q1Options);
        CoinFlip.SetActive(true);
        H1.SetActive(true);
        H2.SetActive(false);
        H3.SetActive(false);
        HintEnable.EnableHintUsage(true);
        HintButtonEnable.EnableOpenHint();
        coin.SetMaxFlips(1);
    }

    public void D6Show()
    {
        if (hasShownD6) return;
        hasShownD6 = true;
        ShowDialogue(D6);
    }

    public void D7Show()
    {
        if (hasShownD7) return;
        hasShownD7 = true;
        ShowDialogue(D7);
    }

    public void Q2Show()
    {
        if (hasShownQ2) return;
        hasShownQ2 = true;
        ShowDialogue(Q2Options);
        CoinFlip.SetActive(true);
        H1.SetActive(false);
        H2.SetActive(true);
        H3.SetActive(false);
        HintEnable.EnableHintUsage(true);
        coin.SetMaxFlips(2);
    }

    public void D8Show()
    {
        if (hasShownD8) return;
        hasShownD8 = true;
        ShowDialogue(D8);
    }

    public void D9Show()
    {
        if (hasShownD9) return;
        hasShownD9 = true;
        ShowDialogue(D9);
    }

    public void Q3Show()
    {
        if (hasShownQ3) return;
        hasShownQ3 = true;
        ShowDialogue(Q3Options);
        CoinFlip.SetActive(true);
        H1.SetActive(false);
        H2.SetActive(false);
        H3.SetActive(true);
        HintEnable.EnableHintUsage(true);
        coin.SetMaxFlips(10);
    }

    public void D10Show()
    {
        if (hasShownD10) return;
        hasShownD10 = true;
        ShowDialogue(D10);
    }

    public void Completed()
    {
        D10.SetActive(false);
        Q3Options.SetActive(false);
        ShowDialogue(Portal);
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
        CoinFlip.SetActive(false);
        Q1Options.SetActive(false);
        Q2Options.SetActive(false);
        Q3Options.SetActive(false);
        Portal.SetActive(false);

        // Show the requested dialogue
        dialogue.SetActive(true);
    }
}
