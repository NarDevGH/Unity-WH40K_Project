using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimController : MonoBehaviour
{
    public Animator animator;

    public float VelocityX() { return animator.GetFloat("velocityX"); }
    public void SetVelocityX(float value) {
        animator.SetFloat("velocityX", value);
    }

    public float VelocityY() { return animator.GetFloat("velocityY"); }
    public void SetVelocityY(float value)
    {
        animator.SetFloat("velocityY", value);
    }

    public void MoveDirectionAnim(Vector2 dir)
    {
        SetVelocityX(dir.x);
        SetVelocityY(dir.y);
    }

    public Vector2 GetMoveDirection() {
        return new Vector2( VelocityX(), VelocityY() );
    }

    public bool IsStanding() { return animator.GetBool("standing"); }
    public void SetStanding(bool value)
    {
        animator.SetBool("standing", value);
    }

    public bool IsDeath() { return animator.GetBool("death"); }

    public void PlayDeathAnim(float deathAnimID) {
        animator.SetFloat("deathFrom", deathAnimID);
        animator.SetBool("death", true);
    }

}
