using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Health : MonoBehaviour
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private CharacterAnimController charAnimController;
    public void Damage(float ammount, float damageMult, bool headshot, Vector3 dir) {
        _health -= ammount * damageMult;

        float shotDir = Vector3.Dot(transform.forward.normalized, dir.normalized);

        if (_health <= 0) {

            float _deathAnimID = 0f;

            if (headshot)
            {
                if (shotDir < 0)
                {
                    _deathAnimID = .25f;
                }
                else
                {
                    _deathAnimID = .75f;
                }
            }
            else {
                if (shotDir < 0)
                {
                    _deathAnimID = 0f;
                }
                else {
                    _deathAnimID = .5f;
                }
            }

            charAnimController.PlayDeathAnim(_deathAnimID);
        }

    }
}
