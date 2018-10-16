using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using Cinemachine;

public class ShakeOnce : MonoBehaviour {

    public CameraShaker cameraShake;

	void Shake()
    {
        cameraShake.ShakeOnce(0.5f, 0.5f, 0.5f, 0.5f);
    }
}
