using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_DamageRegistration : MonoBehaviour
{
    [SerializeField] private float _damageMult = 1f;
    [SerializeField] private bool _head;
    [SerializeField] private NPC_Health healtScript;

    public void Damage(float ammount, Vector3 dir) {
        healtScript.Damage(ammount, _damageMult, _head, dir);
    }
}
