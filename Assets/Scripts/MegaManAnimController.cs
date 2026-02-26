using UnityEngine;
using UnityEngine.InputSystem;

public class MegaManAnimController : MonoBehaviour
{
    public Animator megaManAnimController;

    public int isIdleHash = Animator.StringToHash("isIdle");

    public void Start()
    {
        megaManAnimController = GetComponent<Animator>();
    }

     public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        float direction = input.x; 

        //isIdle
        if (direction == 0)
        {
            megaManAnimController.SetBool(isIdleHash, true);
        }
        else
        {
            megaManAnimController.SetBool(isIdleHash, false);
        }

        // Flip the character based on movement direction

    }
}
