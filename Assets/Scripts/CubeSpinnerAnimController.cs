using UnityEngine;
using UnityEngine.InputSystem;

public class CubeSpinnerAnimController : MonoBehaviour
{
    public Animator cubeAnimController;

    //private int isRotatingHash = Animator.StringToHash("isRotating");

    public void Start()
    {
        cubeAnimController = GetComponent<Animator>();
    }

    public void OnSpin(InputAction.CallbackContext context)
    {
        Debug.Log("Toggled Spin");

        if(context.performed && cubeAnimController.GetBool("isRotating") == false)
        {
            // animator = spin cube
            cubeAnimController.SetBool("isRotating", true);
        }

        else if (context.performed && cubeAnimController.GetBool("isRotating") == true)
        {
            // animator = stop spinning cube
            cubeAnimController.SetBool("isRotating", false);
        }
    }
}
