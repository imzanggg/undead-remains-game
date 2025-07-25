using UnityEngine;
using StarterAssets;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationScript : MonoBehaviour
{
    private Animator animator;
    private StarterAssetsInputs input; // from Starter Assets
    private CharacterController controller;
    private Transform root; // root PlayerCapsule

    void Start()
    {
        animator = GetComponent<Animator>();

        // Find root and input/controller
        root = transform.root;
        input = root.GetComponentInChildren<StarterAssetsInputs>();
        controller = root.GetComponent<CharacterController>();

        if (input == null)
            Debug.LogError("StarterAssetsInputs not found in children of root!");
        if (controller == null)
            Debug.LogError("CharacterController not found on root!");
    }


    void Update()
    {
        // Movement input values (-1 to 1)
        float moveX = input.move.x;
        float moveY = input.move.y;

        // Approximate speed from CharacterController
        float speed = new Vector2(controller.velocity.x, controller.velocity.z).magnitude;

        // Set movement parameters
        animator.SetFloat("Speed", speed);
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);

        // Set state flags from input system
        animator.SetBool("IsJumping", !controller.isGrounded);
        animator.SetBool("IsFiring", input.shoot);  
        animator.SetBool("IsReloading", input.reload);         
        animator.SetBool("IsGrenade", input.grenade);          

        // Example trigger for hit animation
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("IsHit");
        }
    }
}
