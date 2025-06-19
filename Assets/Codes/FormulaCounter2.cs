using UnityEngine;

public class FormulaCounter2 : MonoBehaviour
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
        if (counter < 3)
        {
            wrong.SetActive(true);
            score.DecrementScore(2);
        }
        else if (counter == 3)
        {
            correct.SetActive(true);
            score.IncrementScore(5);
            percent.IncrementProgress(10);
            DragCanvas.SetActive(false);
        }
    }

    public void WrongCanvasClose()
    {
        wrong.SetActive(false);
    }
}
