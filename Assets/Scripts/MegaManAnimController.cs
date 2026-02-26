using UnityEngine;
using UnityEngine.InputSystem;

public class MegaManAnimController : MonoBehaviour
{
    public Animator megaManAnimController;

    

    public void Start()
    {
        megaManAnimController = GetComponent<Animator>();
    }

     
}
