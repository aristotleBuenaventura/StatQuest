using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public string boxTag = "Plank"; // Tag of the box to detect collisions with
    private Rigidbody2D rb;
    public FormulaCounter2 count;

    private void Start()
    {
        // Ensure the object has a Rigidbody2D for collision detection
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.isKinematic = true; // Ensure the Rigidbody2D is not affected by physics but still detects collisions
        }

        // Make sure the object has a Collider2D component
        if (GetComponent<Collider2D>() == null)
        {
            Debug.LogError("No Collider2D found on the draggable object.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the collided object has the specified box tag, log true
        if (other.CompareTag(boxTag))
        {
            count.Increment();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // If the collided object has the specified box tag, log false
        if (other.CompareTag(boxTag))
        {
            count.Decrement();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
