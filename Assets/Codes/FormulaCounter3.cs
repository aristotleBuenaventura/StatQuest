using UnityEngine;

public class FormulaCounter3 : MonoBehaviour
{
    public int counter = 0;
    public GameObject wrong;
    public GameObject correct;
    public GameObject DragCanvas;
    public ScoreManager score;
    public ProgressBar percent;

    public void Increment()
    {
        counter++;
        Debug.Log("Counter increment: " + counter);
    }

    public void Decrement()
    {
        counter--;
        Debug.Log("Counter decrement: " + counter);
    }

    public void CheckerCount()
    {
        if (counter < 2)
        {
            wrong.SetActive(true);
            score.DecrementScore(5);
        }
        else if (counter == 2)
        {
            score.IncrementScore(5);
            percent.IncrementProgress(20);
            correct.SetActive(true);
            DragCanvas.SetActive(false);
            wrong.SetActive(false);
        }
    }

    public void WrongCanvasClose()
    {
        wrong.SetActive(false);
    }
}
