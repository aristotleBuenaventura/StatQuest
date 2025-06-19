using UnityEngine;

public class HouseAppear : MonoBehaviour
{
    public MaterialChecker material;
    public string material1, material2, wrongMaterial;
    public GameObject wood1, wood2, c1, house, woods, circle, wrong, correct;
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
                    wood1.SetActive(false);
                    Debug.Log("Material1 working");
                    carryMaterial.SetCarryState(false);
                }
                else if (material.MaterialName == material2)
                {
                    material.SetMaterialName("STOP");
                    counter++;
                    wood2.SetActive(false);
                    Debug.Log("Material2 working");
                    carryMaterial.SetCarryState(false);
                }
                

                if (counter == 1)
                {
                    correct.SetActive(true);
                }
                else if (counter == 2)
                {
                    c1.SetActive(true);
                    house.SetActive(true);
                    woods.SetActive(false);
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
