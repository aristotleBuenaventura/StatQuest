using UnityEngine;

public class ChangeBaseColor : MonoBehaviour
{
    private Renderer objRenderer;

    void Start()
    {
        // Get the Renderer component
        objRenderer = GetComponent<Renderer>();
    }

    public void SetBaseColor(string hexColor)
    {
        if (objRenderer != null)
        {
            if (ColorUtility.TryParseHtmlString(hexColor, out Color newColor))
            {
                // Change the Base Map (Albedo) color
                objRenderer.material.SetColor("_BaseColor", newColor); // URP/HDRP
                // Alternative for Standard Shader: objRenderer.material.color = newColor;
            }
            else
            {
                Debug.LogError("Invalid Hex Color Code!");
            }
        }
        else
        {
            Debug.LogError("No Renderer found on the GameObject.");
        }
    }
}
