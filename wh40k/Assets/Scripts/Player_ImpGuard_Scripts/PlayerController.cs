using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] private ShadowAnim_Controller shadowAnimController;
    [SerializeField] private CharacterPhysics charPhysics;
    [SerializeField] private CameraController camController;

    private float movementX;
    private float movementY;



    private void Update()
    {
        AxisInput();

        if (!Input.GetKey(KeyCode.LeftShift)) {
            movementX = Mathf.Clamp(movementX ,-.5f, .5f);
            movementY = Mathf.Clamp(movementY, -.5f, .5f);
        }

        shadowAnimController.MoveDirectionAnim(new Vector2(movementX, movementY) );

        if (Input.GetKeyDown(KeyCode.C)) {
            shadowAnimController.SetStanding(!shadowAnimController.IsStanding());
            charPhysics.SwapColliders();
            camController.SwapCamPosition();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shadowAnimController.IsStanding())
            {
                shadowAnimController.Jump();
            }
        }
        if(Input.GetKeyUp(KeyCode.Space)) { shadowAnimController.ResetJump(); }
    }


    private void AxisInput()
    {
        movementX = Input.GetAxis("Horizontal");
        movementY = Input.GetAxis("Vertical");
    }
}
