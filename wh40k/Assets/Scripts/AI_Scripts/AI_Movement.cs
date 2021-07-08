using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Movement : MonoBehaviour
{

    [SerializeField] private float acceleration;

    [SerializeField] private CharacterAnimController charAnimController;

    [Range(-1,1)]
    public float test;

    private Vector2 charTargetSpeed;
    private Vector2 charCurrentSpeed;



    private void Update()
    {
        charTargetSpeed.y = test;
        charCurrentSpeed = Vector2.MoveTowards(charCurrentSpeed, charTargetSpeed, 1 * acceleration * Time.deltaTime);
        charAnimController.MoveDirectionAnim(charCurrentSpeed);
    }

    public void WalkForward() {
        charTargetSpeed.y = .5f;
    }

    public void RunForward()
    {
        charTargetSpeed.y = 1f;
    }

    public void WalkBackwards()
    {
        charTargetSpeed.y = -.5f;
    }

    public void RunBackwards()
    {
        charTargetSpeed.y = -1f;
    }

}
