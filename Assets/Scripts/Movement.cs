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
        var input = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * input * Time.deltaTime);
        animator.SetBool("walk", input != 0);
        animator.SetFloat("walkSpeed", input);
    }
}