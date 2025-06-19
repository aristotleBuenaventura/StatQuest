using UnityEngine;

public class HouseAppear2 : MonoBehaviour
{
    public MaterialChecker material;
    public string material1, material2, wrongMaterial;
    public GameObject ply1, ply2, c2, house, plys, circle, wrong, correct, house1;
    public PlayerWithJump carryMaterial;

    private int counter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (material.MaterialName == material1 || material.MaterialName == material2)
            {
                if (material.MaterialName == material1)
                {
                    material.SetMaterialName("STOP");
                    counter++;
                    ply1.SetActive(false);
                    Debug.Log("Material1 working");
                    carryMaterial.SetCarryState(false);
                }
                else if (material.MaterialName == material2)
                {
                    material.SetMaterialName("STOP");
                    counter++;
                    ply2.SetActive(false);
                    Debug.Log("Material2 working");
                    carryMaterial.SetCarryState(false);
                }


                if (counter == 1)
                {
                    correct.SetActive(true);
                }
                else if (counter == 2)
                {
                    c2.SetActive(true);
                    house1.SetActive(false);
                    house.SetActive(true);
                    plys.SetActive(false);
                    Debug.Log("Counter: " + counter);
                    carryMaterial.SetCarryState(false);
                    circle.SetActive(false);
                }
            }
            else if (material.MaterialName == wrongMaterial)
            {
                wrong.SetActive(true);
                carryMaterial.SetCarryState(false);
            }
        }
    }


}
