using UnityEngine;

public class DialogueDisplayS3Second : MonoBehaviour
{
    public GameObject D44, D45, I46, D47, D48, I49, D50, I51, D52, D53, I54, I55, D56, I57, I58, I59, I60, I61, I63, I64, I65, I66, I67, I68, D69, I70, I71, I72, I73, D74;
    public GameObject DraggableVariance, DraggableSortValues, DraggableMeanForSetAandSetB;
    public GameObject portal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        D44.SetActive(false);
        D45.SetActive(false);
        I46.SetActive(false);
        D47.SetActive(false);
        D48.SetActive(false);
        I49.SetActive(false);
        D50.SetActive(false);
        I51.SetActive(false);
        D52.SetActive(false);
        D53.SetActive(false);
        I54.SetActive(false);
        I55.SetActive(false);
        D56.SetActive(false);
        I57.SetActive(false);
        I58.SetActive(false);
        I59.SetActive(false);
        I60.SetActive(false);
        I61.SetActive(false);
        I63.SetActive(false);
        I64.SetActive(false);
        I65.SetActive(false);
        I66.SetActive(false);
        I67.SetActive(false);
        I68.SetActive(false);
        D69.SetActive(false);
        I70.SetActive(false);
        I71.SetActive(false);
        I72.SetActive(false);
        I73.SetActive(false);
        D74.SetActive(false);

        // Initialize draggable items if necessary
        DraggableVariance.SetActive(false);
        DraggableSortValues.SetActive(false);
        DraggableMeanForSetAandSetB.SetActive(false);
    }

    public void D44Show()
    {
        ShowDialogue(D44);
    }

    public void D45Show()
    {
        ShowDialogue(D45);
    }

    public void I46Show()
    {
        ShowDialogue(I46);
    }

    public void D47Show()
    {
        ShowDialogue(D47);
    }

    public void D48Show()
    {
        ShowDialogue(D48);
    }

    public void I49Show()
    {
        ShowDialogue(I49);
    }

    public void D50Show()
    {
        ShowDialogue(D50);
    }

    public void I51Show()
    {
        ShowDialogue(I51);
    }

    public void D52Show()
    {
        ShowDialogue(D52);
    }

    public void D53Show()
    {
        ShowDialogue(D53);
    }

    public void I54Show()
    {
        ShowDialogue(I54);
    }

    public void I55Show()
    {
        ShowDialogue(I55);
    }

    public void D56Show()
    {
        ShowDialogue(D56);
    }

    public void I57Show()
    {
        ShowDialogue(I57);
    }

    public void I58Show()
    {
        ShowDialogue(I58);
    }

    public void I59Show()
    {
        ShowDialogue(I59);
    }

    public void I60Show()
    {
        ShowDialogue(I60);
    }

    public void DraggableMeanForSetAandSetBShow()
    {
        ShowDialogue(DraggableMeanForSetAandSetB);
    }

    public void I61Show()
    {
        ShowDialogue(I61);
    }

    public void I63Show()
    {
        ShowDialogue(I63);
    }

    public void I64Show()
    {
        ShowDialogue(I64);
    }

    public void I65Show()
    {
        ShowDialogue(I65);
    }

    public void I66Show()
    {
        ShowDialogue(I66);
    }

    public void I67Show()
    {
        ShowDialogue(I67);
    }

    public void DraggableVarianceShow()
    {
        ShowDialogue(DraggableVariance);
    }

    public void I68Show()
    {
        ShowDialogue(I68);
    }

    public void D69Show()
    {
        ShowDialogue(D69);
    }

    public void I70Show()
    {
        ShowDialogue(I70);
    }

    public void I71Show()
    {
        ShowDialogue(I71);
    }

    public void I72Show()
    {
        ShowDialogue(I72);
    }

    public void DraggableSortValuesShow()
    {
        ShowDialogue(DraggableSortValues);
    }

    public void I73Show()
    {
        ShowDialogue(I73);
    }

    public void D74Show()
    {
        ShowDialogue(D74);
    }

    public void D74Close()
    {
        portal.SetActive(true);
        D74.SetActive(false);
    }

    private void ShowDialogue(GameObject dialogue)
    {
        // Deactivate all dialogues
        D44.SetActive(false);
        D45.SetActive(false);
        I46.SetActive(false);
        D47.SetActive(false);
        D48.SetActive(false);
        I49.SetActive(false);
        D50.SetActive(false);
        I51.SetActive(false);
        D52.SetActive(false);
        D53.SetActive(false);
        I54.SetActive(false);
        I55.SetActive(false);
        D56.SetActive(false);
        I57.SetActive(false);
        I58.SetActive(false);
        I59.SetActive(false);
        I60.SetActive(false);
        I61.SetActive(false);
        I63.SetActive(false);
        I64.SetActive(false);
        I65.SetActive(false);
        I66.SetActive(false);
        I67.SetActive(false);
        I68.SetActive(false);
        D69.SetActive(false);
        I70.SetActive(false);
        I71.SetActive(false);
        I72.SetActive(false);
        I73.SetActive(false);
        D74.SetActive(false);

        DraggableVariance.SetActive(false);
        DraggableSortValues.SetActive(false);
        DraggableMeanForSetAandSetB.SetActive(false);

        // Show the selected dialogue
        dialogue.SetActive(true);
    }
}
