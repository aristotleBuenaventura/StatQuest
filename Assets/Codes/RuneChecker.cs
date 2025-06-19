using UnityEngine;

public class RuneChecker : MonoBehaviour
{
    private string runeName;

    public string RuneName
    {
        get { return runeName; }
    }

    public void SetPebbleNameState(string rune)
    {
        Debug.Log("Setting Pebble Name to: " + rune);
        runeName = rune;
    }


}
