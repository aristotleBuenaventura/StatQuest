using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
    public Image[] hintImages; // Assign 3 images in Inspector
    private int hintsRemaining;
    private bool canUseHint = false; // Controls if UseHint() can be called
    public ScoreManager score;

    void Start()
    {
        hintsRemaining = hintImages.Length;
    }

    public void UseHint()
    {
        if (hintsRemaining > 0 && canUseHint)
        {
            hintsRemaining--;
            score.DecrementScore(3);
            hintImages[hintsRemaining].enabled = false; // Hide used hint
            canUseHint = false; // Disable further usage until re-enabled
        }
    }

    public void EnableHintUsage(bool enable)
    {
        canUseHint = enable;
    }
}
