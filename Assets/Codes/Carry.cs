using UnityEngine;

public class Carry : MonoBehaviour
{
    public bool isCarry = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isCarry)
        {
            animator.SetTrigger("carry");
        }
        else
        {
            animator.SetTrigger("idle");
        }
    }
}