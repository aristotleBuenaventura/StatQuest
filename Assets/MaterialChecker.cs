using UnityEngine;

public class MaterialChecker : MonoBehaviour
{
    private string materialName;

    public string MaterialName
    {
        get { return materialName; }
    }

    public void SetMaterialName(string material)
    {
        Debug.Log("Material: " +  material);
        materialName = material;
    }
}
