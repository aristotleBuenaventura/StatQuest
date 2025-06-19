using UnityEngine;

public class DialogueDisplayMap : MonoBehaviour
{
    public GameObject WelcomeMessage, MeetTash;
    void Start()
    {
        WelcomeMessage.SetActive(false);
        MeetTash.SetActive(false);
    }

    public void WelcomeMessageShow()
    {
        ShowDialogue(WelcomeMessage);
    }

    public void MeetTashShow()
    {
        ShowDialogue(MeetTash);
    }

    public void MeetTashClose()
    {
        MeetTash.SetActive(false);
    }

    private void ShowDialogue(GameObject dialogue)
    {
        WelcomeMessage.SetActive(false);
        MeetTash.SetActive(false);

        dialogue.SetActive(true);
    }
}
