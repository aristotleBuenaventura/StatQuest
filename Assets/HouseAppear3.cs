using UnityEngine;

public class HouseAppear3 : MonoBehaviour
{
    public MaterialChecker material;
    public string material1, wrongMaterial;
    public GameObject roof1, c3, house, roofs, circle, wrong, correct, house1;
    public PlayerWithJump carryMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (material.MaterialName == material1)
            {
                if (material.MaterialName == material1)
                {
                    c3.SetActive(true);
                    house.SetActive(false);
                    house1.SetActive(true);
                    roofs.SetActive(false);
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
