using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetBool("walk", Input.GetAxis("Vertical") != 0);
    }
}