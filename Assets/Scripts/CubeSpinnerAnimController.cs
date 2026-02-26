using UnityEngine;
using UnityEngine.InputSystem;

public class CubeSpinnerAnimController : MonoBehaviour
{
    public Animator cubeAnimController;

    private int isRotatingHash = Animator.StringToHash("isRotating");

    public void Start()
    {
        cubeAnimController = GetComponent<Animator>();
    }

    public void OnSpin(InputAction.CallbackContext context)
    {
        Debug.Log("Toggled Spin");

        if(context.performed && cubeAnimController.GetBool(isRotatingHash) == true)
        {
            // animator = spin cube
            cubeAnimController.SetBool(isRotatingHash, false);
        }

        else if (context.performed && cubeAnimController.GetBool(isRotatingHash) == false)
        {
            // animator = stop spinning cube
            cubeAnimController.SetBool(isRotatingHash, true);
        }
    }
}
