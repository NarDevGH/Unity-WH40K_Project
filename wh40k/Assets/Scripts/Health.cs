using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;
    public void Damage(float ammount, Vector3 dir)
    {
        _health -= ammount;

        if (_health <= 0)
        {

        }
    }
}
