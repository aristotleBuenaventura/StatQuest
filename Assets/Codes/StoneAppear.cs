using UnityEngine;

public class StoneAppear : MonoBehaviour
{
    public PlayerWithJump carryPebble;
    public GameObject pebble7;
    public GameObject pebble26;
    public GameObject pebble2Violet;
    public GameObject pebble11;
    public GameObject pebble2Pink;

    public GameObject pebble7Ground;
    public GameObject pebble26Ground;
    public GameObject pebble2VioletGround;
    public GameObject pebble11Ground;
    public GameObject pebble2PinkGround;
    public PebbleChecker checker;

    public bool is7 = true;
    public bool is26 = true;
    public bool is2V = true;
    public bool is11 = true;
    public bool is2P = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pebble7"))
        {
            carryPebble.SetCarryState(true);
            pebble7.SetActive(true);
            pebble26.SetActive(false);
            pebble2Violet.SetActive(false);
            pebble11.SetActive(false);
            pebble2Pink.SetActive(false);
            Debug.Log("Pebble7");
            pebble7Ground.SetActive(false);

            pebble26Ground.SetActive(true);
            pebble2VioletGround.SetActive(true);
            pebble11Ground.SetActive(true);
            pebble2PinkGround.SetActive(true);

            checker.SetPebbleNameState("Pebble7");

        } 
        else if (collision.gameObject.CompareTag("Pebble2Violet"))
        {
            carryPebble.SetCarryState(true);
            pebble7.SetActive(false);
            pebble26.SetActive(false);
            pebble2Violet.SetActive(true);
            pebble11.SetActive(false);
            pebble2Pink.SetActive(false);
            Debug.Log("Pebble2Violet");
            pebble2VioletGround.SetActive(false);

            pebble7Ground.SetActive(true);
            pebble26Ground.SetActive(true);
            pebble11Ground.SetActive(true);
            pebble2PinkGround.SetActive(true);

            checker.SetPebbleNameState("Pebble2Violet");
        }
        else if (collision.gameObject.CompareTag("Pebble26"))
        {
            carryPebble.SetCarryState(true);
            pebble7.SetActive(false);
            pebble26.SetActive(true);
            pebble2Violet.SetActive(false);
            pebble11.SetActive(false);
            pebble2Pink.SetActive(false);
            Debug.Log("Pebble26");
            pebble26Ground.SetActive(false);

            pebble7Ground.SetActive(true);
            pebble2VioletGround.SetActive(true);
            pebble11Ground.SetActive(true);
            pebble2PinkGround.SetActive(true);

            checker.SetPebbleNameState("Pebble26");
        }
        else if (collision.gameObject.CompareTag("Pebble2Pink"))
        {
            carryPebble.SetCarryState(true);
            pebble7.SetActive(false);
            pebble26.SetActive(false);
            pebble2Violet.SetActive(false);
            pebble11.SetActive(false);
            pebble2Pink.SetActive(true);
            Debug.Log("Pebble2Pink");
            pebble2PinkGround.SetActive(false);

            pebble7Ground.SetActive(true);
            pebble26Ground.SetActive(true);
            pebble2VioletGround.SetActive(true);
            pebble11Ground.SetActive(true);

            checker.SetPebbleNameState("Pebble2Pink");
        }
        else if (collision.gameObject.CompareTag("Pebble11"))
        {
            carryPebble.SetCarryState(true);
            pebble7.SetActive(false);
            pebble26.SetActive(false);
            pebble2Violet.SetActive(false);
            pebble11.SetActive(true);
            pebble2Pink.SetActive(false);
            Debug.Log("Pebble11");
            pebble11Ground.SetActive(false);

            pebble7Ground.SetActive(true);
            pebble26Ground.SetActive(true);
            pebble2VioletGround.SetActive(true);
            pebble2PinkGround.SetActive(true);

            checker.SetPebbleNameState("Pebble11");
        }
    }
}