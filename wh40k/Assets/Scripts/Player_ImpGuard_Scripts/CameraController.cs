using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private Transform camPosStanding;
    [SerializeField] private Transform camPosCrouched;

    private bool standing = true;

    public void SwapCamPosition() {
        if (standing)
        {
            cam.position = camPosCrouched.position;
        }
        else {
            cam.position = camPosStanding.position;
        }

        standing = !standing;
    }

}
