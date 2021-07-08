using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharAnimController : MonoBehaviour
{
    [SerializeField] private Animator shadowsAnimator;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public float VelocityX() { return animator.GetFloat("velocityX"); }
    public void SetVelocityX(float value) {
        animator.SetFloat("velocityX", value);
        shadowsAnimator.SetFloat("velocityX", value);
    }

    public float VelocityY() { return animator.GetFloat("velocityY"); }
    public void SetVelocityY(float value)
    {
        animator.SetFloat("velocityY", value);
        shadowsAnimator.SetFloat("velocityY", value);
    }

    public void MoveDirectionAnim(Vector2 dir)
    {
        SetVelocityX(dir.x);
        SetVelocityY(dir.y);
    }

    public bool IsStanding() { return animator.GetBool("standing"); }
    public void SetStanding(bool value)
    {
        animator.SetBool("standing", value);
        shadowsAnimator.SetBool("standing", value);
    }

    public void Jump() {
        animator.SetTrigger("jump");
    }

    public void ResetJump() {
        animator.ResetTrigger("jump");
    }
}
