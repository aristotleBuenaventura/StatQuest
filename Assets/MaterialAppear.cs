using UnityEngine;

public class MaterialAppear : MonoBehaviour
{
    public PlayerWithJump carryMaterial;
    public MaterialChecker material;
    public GameObject Roof, Wood, Plywood;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wood1") || collision.gameObject.CompareTag("Wood2") || collision.gameObject.CompareTag("Wood3") || collision.gameObject.CompareTag("Wood4"))
        {
            carryMaterial.SetCarryState(true);

            Wood.SetActive(true);
            Roof.SetActive(false);
            Plywood.SetActive(false);

            if (collision.gameObject.CompareTag("Wood1"))
            {
                material.SetMaterialName("WoodCorrect1");
            } else if (collision.gameObject.CompareTag("Wood2"))
            {
                material.SetMaterialName("WRONG");
            }
            else if (collision.gameObject.CompareTag("Wood3"))
            {
                material.SetMaterialName("WRONG");
            }
            else if (collision.gameObject.CompareTag("Wood4"))
            {
                material.SetMaterialName("WoodCorrect2");
            }

        }
        else if (collision.gameObject.CompareTag("Ply1") || collision.gameObject.CompareTag("Ply2") || collision.gameObject.CompareTag("Ply3") || collision.gameObject.CompareTag("Ply4"))
        {
            carryMaterial.SetCarryState(true);

            Wood.SetActive(false);
            Roof.SetActive(false);
            Plywood.SetActive(true);

            if (collision.gameObject.CompareTag("Ply1"))
            {
                material.SetMaterialName("PlyCorrect1");
            }
            else if (collision.gameObject.CompareTag("Ply2"))
            {
                material.SetMaterialName("WRONG");
            }
            else if (collision.gameObject.CompareTag("Ply3"))
            {
                material.SetMaterialName("PlyCorrect2");
            }
            else if (collision.gameObject.CompareTag("Ply4"))
            {
                material.SetMaterialName("WRONG");
            }

        }
        else if (collision.gameObject.CompareTag("Roof1") || collision.gameObject.CompareTag("Roof2") || collision.gameObject.CompareTag("Roof3") || collision.gameObject.CompareTag("Roof4"))
        {
            carryMaterial.SetCarryState(true);

            Wood.SetActive(false);
            Roof.SetActive(true);
            Plywood.SetActive(false);

            if (collision.gameObject.CompareTag("Roof1"))
            {
                material.SetMaterialName("RoofCorrect1");
            }
            else if (collision.gameObject.CompareTag("Roof2"))
            {
                material.SetMaterialName("WRONG");
            }
            else if (collision.gameObject.CompareTag("Roof3"))
            {
                material.SetMaterialName("WRONG");
            }
            else if (collision.gameObject.CompareTag("Roof4"))
            {
                material.SetMaterialName("WRONG");
            }

        }

    }
}
