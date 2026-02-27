using UnityEngine;
using UnityEngine.InputSystem;

public class MegaManAnimController : MonoBehaviour
{
    public Animator megaManAnimController;

    private int isIdleHash = Animator.StringToHash("isIdle");
    //private int directionHash = Animator.StringToHash("Direction");

    public void Start()
    {
        //get animator component
        megaManAnimController = GetComponent<Animator>();
    }

     public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        float direction = input.x; 

        //megaManAnimController.SetFloat(directionHash, direction);
        
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
        if (direction == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // Face left
        }
        else if (direction == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // Face right
        }

        //had to change Direction parameter to a float for it to work in the animator
    }
}
