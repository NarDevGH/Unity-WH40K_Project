using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Zombie : MonoBehaviour
{
    AIRoot AI;
    Animator anim;
    public float attackDist;
    public float hitpoints = 100f;
    public UnityEvent onDeath;

    void Start()
    {
        AI = GetComponent<AIRoot>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Vector3.Distance(AI.transform.position, AI.target.position) < attackDist)
        {
            anim.SetBool("Attack", true);
            GiveDamage();
        }
        else {
            anim.SetBool("Attack", false);
        }
    }

    void GiveDamage() { 
    }

    void Damage(float damage)
    {
        hitpoints = hitpoints - damage;
        if (hitpoints <= 0) {
            Destroy(gameObject, 5);
            onDeath.Invoke();
        }
    }
}
