using UnityEngine;

public class DialogueDisplayS2 : MonoBehaviour
{
    public GameObject D1, D2, D3;
    public ProgressBar progress;
    public HintShow HintEnable;
    public AudioSource A1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
    }

    public void D2Show()
    {
        ShowDialogue(D2);
    }

    public void D3Show()
    {
        ShowDialogue(D3);
        progress.IncrementProgress(10);
        HintEnable.EnableOpenHint();
    }

    private void ShowDialogue(GameObject dialogue)
    {
        // Disable all dialogues
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);

        // Show the requested dialogue
        dialogue.SetActive(true);
    }

}
