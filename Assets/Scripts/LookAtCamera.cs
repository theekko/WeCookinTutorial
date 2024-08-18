using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {


    private enum Mode {
        LookAt,
        LookAtInverted,
        CameraForward,
        CameraForwardInverted
    }

    [SerializeField] private Mode mode;


    private void LateUpdate() {
        switch (mode) {
            case Mode.LookAt:
                transform.LookAt(Camera.main.transform); 
                break;
            case Mode.LookAtInverted:
                // Gives the direction away from the camera (if the camera is to your left this points to the right)
                Vector3 dirFromCamera = transform.position - Camera.main.transform.position;
                // takes your position and turns it away from the Camera
                transform.LookAt(transform.position + dirFromCamera);
                break;
            case Mode.CameraForward:
                transform.forward = Camera.main.transform.forward;
                break;
            case Mode.CameraForwardInverted:
                transform.forward = -Camera.main.transform.forward;
                break; 
        }
        
    }
}
