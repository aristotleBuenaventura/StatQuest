using UnityEngine;

public class PebbleChecker : MonoBehaviour
{
    public GameObject pebble7Ground;
    public GameObject pebble26Ground;
    public GameObject pebble2VioletGround;
    public GameObject pebble11Ground;
    public GameObject pebble2PinkGround;

    public GameObject pebble7Mid;
    public GameObject pebble26Mid;
    public GameObject pebble2VioletMid;
    public GameObject pebble11Mid;
    public GameObject pebble2PinkMid;
    public AudioSource Wrong;
    public PlayerWithJump isCarry;
    private string pebbleName;

    public string PebbleName
    {
        get { return pebbleName; }
    }

    public void SetPebbleNameState(string pebble)
    {
        Debug.Log("Setting Pebble Name to: " + pebble);
        pebbleName = pebble;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
        {
            if (pebbleName == "Pebble7")
            {
                Debug.Log("Pebble7 detected!");
                Wrong.Play();
                pebble7Mid.SetActive(true);
                pebble26Mid.SetActive(false);
                pebble2VioletMid.SetActive(false);
                pebble11Mid.SetActive(false);
                pebble2PinkMid.SetActive(false);
                if (isCarry != null) isCarry.SetCarryState(false);
                pebble7Ground.SetActive(false);
                //Destroy(pebble7Ground, 0.1f);
            }
            if (pebbleName == "Pebble2Violet")
            {
                Debug.Log("Pebble2Violet detected!");
                
                pebble7Mid.SetActive(false);
                pebble26Mid.SetActive(false);
                pebble2VioletMid.SetActive(true);
                pebble11Mid.SetActive(false);
                pebble2PinkMid.SetActive(false);
                pebble2VioletGround.SetActive(false);
                //Destroy(pebble2VioletGround, 0.1f);
                if (isCarry != null) isCarry.SetCarryState(false);
            }
            if (pebbleName == "Pebble26")
            {
                Debug.Log("Pebble26 detected!");
                Wrong.Play();
                pebble7Mid.SetActive(false);
                pebble26Mid.SetActive(true);
                pebble2VioletMid.SetActive(false);
                pebble11Mid.SetActive(false);
                pebble2PinkMid.SetActive(false);
                pebble26Ground.SetActive(false);
                //Destroy(pebble26Ground, 0.1f);
                if (isCarry != null) isCarry.SetCarryState(false);
            }
            if (pebbleName == "Pebble2Pink")
            {
                Debug.Log("Pebble2Pink detected!");
                pebble7Mid.SetActive(false);
                pebble26Mid.SetActive(false);
                pebble2VioletMid.SetActive(false);
                pebble11Mid.SetActive(false);
                pebble2PinkMid.SetActive(true);
                pebble2PinkGround.SetActive(false);
                //Destroy(pebble2PinkGround, 0.1f);
                if (isCarry != null) isCarry.SetCarryState(false);
            }
            if (pebbleName == "Pebble11")
            {
                Debug.Log("Pebble11 detected!");
                Wrong.Play();
                pebble7Mid.SetActive(false);
                pebble26Mid.SetActive(false);
                pebble2VioletMid.SetActive(false);
                pebble11Mid.SetActive(true);
                pebble2PinkMid.SetActive(false);
                pebble11Ground.SetActive(false);
                //Destroy(pebble11Ground, 0.1f);
                if (isCarry != null) isCarry.SetCarryState(false);
            }
        }
    }
}
