using UnityEngine;
using System.Collections;

public class CorrectBalloon : MonoBehaviour
{
    public GameObject CorrectCanvas;
    private bool hasCollided = false;
    public GameObject Balloon;
    public float floatSpeed = 2f;  // Speed of floating
    public float floatDuration = 2f;  // Time before disappearing

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Player"))
        {
            hasCollided = true;
            CorrectCanvas.SetActive(true);
            StartCoroutine(FlyUpward());
        }
    }

    private IEnumerator FlyUpward()
    {
        float elapsedTime = 0f;
        Vector3 startPosition = Balloon.transform.position;

        while (elapsedTime < floatDuration)
        {
            Balloon.transform.position += Vector3.up * floatSpeed * Time.deltaTime;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Balloon.SetActive(false);  // Hide the balloon after floating
    }
}
