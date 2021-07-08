using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowAnim_Controller : MonoBehaviour
{
    [SerializeField] private Animator shadowsAnimator;

    public float VelocityX() { return shadowsAnimator.GetFloat("velocityX"); }
    public void SetVelocityX(float value)
    {
        shadowsAnimator.SetFloat("velocityX", value);
    }

    public float VelocityY() { return shadowsAnimator.GetFloat("velocityY"); }
    public void SetVelocityY(float value)
    {
        shadowsAnimator.SetFloat("velocityY", value);
    }

    public void MoveDirectionAnim(Vector2 dir)
    {
        SetVelocityX(dir.x);
        SetVelocityY(dir.y);
    }

    public bool IsStanding() { return shadowsAnimator.GetBool("standing"); }
    public void SetStanding(bool value)
    {
        shadowsAnimator.SetBool("standing", value);
    }

    public void Jump()
    {
        shadowsAnimator.SetTrigger("jump");
    }

    public void ResetJump()
    {
        shadowsAnimator.ResetTrigger("jump");
    }
}
