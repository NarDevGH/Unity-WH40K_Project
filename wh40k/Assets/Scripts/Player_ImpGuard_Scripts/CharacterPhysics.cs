using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPhysics : MonoBehaviour
{
    [SerializeField] private CapsuleCollider colliderStanding;
    [SerializeField] private CapsuleCollider colliderCrouchedDown;

    public void SwapColliders() {
        colliderStanding.enabled = !colliderStanding.enabled;
        colliderCrouchedDown.enabled = !colliderCrouchedDown.enabled;
    }

}
