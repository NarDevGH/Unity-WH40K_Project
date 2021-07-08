using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TriggerFire() { animator.SetTrigger("Fire"); }

    public void ResetTriggerFire() { animator.ResetTrigger("Fire"); }

}
