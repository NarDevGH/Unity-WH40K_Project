using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_FootPlacemet_Curves : MonoBehaviour
{

    Animator anim;

    [Range(0, 1)] 
    [SerializeField] private float _distanceToGround;

    [SerializeField] private LayerMask _groundLayer;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (anim) {

            // Set IK Weights

            anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, anim.GetFloat("IKLeftFootWeight"));
            anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, anim.GetFloat("IKLeftFootWeight"));

            anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, anim.GetFloat("IKRightFootWeight"));
            anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, anim.GetFloat("IKRightFootWeight"));

            //LeftFoot

            RaycastHit hit;
            Ray ray = new Ray(anim.GetIKPosition(AvatarIKGoal.LeftFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, _distanceToGround +1f, _groundLayer)) {

                Vector3 _footPosition = hit.point;
                _footPosition.y += _distanceToGround;
                anim.SetIKPosition(AvatarIKGoal.LeftFoot, _footPosition);

                Vector3 forward = Vector3.ProjectOnPlane(transform.forward, hit.normal); // to fix uphill foot angle
                anim.SetIKRotation(AvatarIKGoal.LeftFoot, new Quaternion( // made this way so the footPlacement doesnt make the legs look weird
                    Quaternion.LookRotation(forward, hit.normal).x,
                    anim.GetIKRotation(AvatarIKGoal.LeftFoot).y,
                    Quaternion.LookRotation(forward, hit.normal).z,
                    Quaternion.LookRotation(forward, hit.normal).w));
            }

            //Right Foot

            ray = new Ray(anim.GetIKPosition(AvatarIKGoal.RightFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, _distanceToGround + 1f, _groundLayer))
            {

                Vector3 _footPosition = hit.point;
                _footPosition.y += _distanceToGround;
                anim.SetIKPosition(AvatarIKGoal.RightFoot, _footPosition);

                Vector3 forward = Vector3.ProjectOnPlane(transform.forward, hit.normal);
                anim.SetIKRotation(AvatarIKGoal.RightFoot, new Quaternion(
                    Quaternion.LookRotation(forward, hit.normal).x,
                    anim.GetIKRotation(AvatarIKGoal.RightFoot).y,
                    Quaternion.LookRotation(forward, hit.normal).z,
                    Quaternion.LookRotation(forward, hit.normal).w));
            }
        }
    }
}
