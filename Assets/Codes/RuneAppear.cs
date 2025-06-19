using UnityEngine;

public class RuneAppear : MonoBehaviour
{
    public PlayerWithJump carryRune;
    public GameObject Rune1, Rune2, Rune3;
    public GameObject Rune1Option1, Rune2Option1, Rune3Option1;
    public GameObject Rune1Option2, Rune2Option2, Rune3Option2;
    public GameObject Rune1Option3, Rune2Option3, Rune3Option3;
    public RuneChecker setRune;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rune1"))
        {
            carryRune.SetCarryState(true);
            Rune1.SetActive(true);
            Rune2.SetActive(false);
            Rune3.SetActive(false);

            Rune1Option1.SetActive(false);
            Rune1Option2.SetActive(false);
            Rune1Option3.SetActive(false);

            Rune2Option1.SetActive(true);
            Rune2Option2.SetActive(true);
            Rune2Option3.SetActive(true);

            Rune3Option1.SetActive(true);
            Rune3Option2.SetActive(true);
            Rune3Option3.SetActive(true);

            setRune.SetPebbleNameState("Rune1");

        } else if (collision.gameObject.CompareTag("Rune2"))
        {
            carryRune.SetCarryState(true);
            Rune1.SetActive(false);
            Rune2.SetActive(true);
            Rune3.SetActive(false);


            Rune1Option1.SetActive(true);
            Rune1Option2.SetActive(true);
            Rune1Option3.SetActive(true);

            Rune2Option1.SetActive(false);
            Rune2Option2.SetActive(false);
            Rune2Option3.SetActive(false);

            Rune3Option1.SetActive(true);
            Rune3Option2.SetActive(true);
            Rune3Option3.SetActive(true);

            setRune.SetPebbleNameState("Rune2");
        } else if (collision.gameObject.CompareTag("Rune3"))
        {
            carryRune.SetCarryState(true);
            Rune1.SetActive(false);
            Rune2.SetActive(false);
            Rune3.SetActive(true);

            

            Rune1Option1.SetActive(true);
            Rune1Option2.SetActive(true);
            Rune1Option3.SetActive(true);

            Rune2Option1.SetActive(true);
            Rune2Option2.SetActive(true);
            Rune2Option3.SetActive(true);

            Rune3Option1.SetActive(false);
            Rune3Option2.SetActive(false);
            Rune3Option3.SetActive(false);

            setRune.SetPebbleNameState("Rune3");

        }

    }
}