using UnityEngine;
using StarterAssets;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationScript : MonoBehaviour
{
    private Animator animator;
    private StarterAssetsInputs input;
    private CharacterController controller;

    void Start()
    {
        animator = GetComponent<Animator>();
        Transform parent = transform.parent;
        input = parent.GetComponent<StarterAssetsInputs>();
        controller = parent.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (input == null || animator == null) return;

        // Movement
        animator.SetFloat("MoveX", input.move.x);
        animator.SetFloat("MoveZ", input.move.y);
        animator.SetBool("IsRunning", input.sprint);
        animator.SetBool("IsJumping", input.jump);

        // One-shot animation booleans (mimic Jump)
        animator.SetBool("IsFiring", input.shoot);
        //animator.SetBool("IsReloading", input.reload);
        //animator.SetBool("IsGrenade", input.grenade);
        if (input.reload)
    {
        // handle reload logic here if needed
        animator.SetTrigger("Reload");  // or SetBool("IsReloading", true)
        //animator.ResetTrigger("IsReloading");
        input.reload = false; // reset after firing once
    }

    if (input.grenade)
    {
        // handle grenade logic here if needed
        animator.SetTrigger("Grenade");  // or SetBool("IsGrenade", true)
        //animator.ResetTrigger("IsGrenade");
        input.grenade = false; // reset after firing once
    }
    }
}
