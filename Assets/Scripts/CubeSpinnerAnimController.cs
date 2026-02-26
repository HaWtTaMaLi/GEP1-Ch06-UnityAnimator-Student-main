using UnityEngine;

public class CubeSpinnerAnimController : MonoBehaviour
{
    public Animator cubeAnimController;

    public void Start()
    {
        cubeAnimController = GetComponent<Animator>();
    }
}
