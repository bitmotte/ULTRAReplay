using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace ULTRAReplay;

class Recorder : MonoBehaviour
{
    int frame;
    void Awake()
    {
        RecordingManager.gunIsShot = false;
    }

    void FixedUpdate()
    {
        Vector3 playerPosition = RecordingManager.player.transform.position;
        Quaternion playerRotation = RecordingManager.player.transform.rotation;
        Quaternion cameraRotation = RecordingManager.camera.transform.rotation;
        RecordingManager.playerPositionVectors.Add(playerPosition);
        RecordingManager.playerRotationQuaternions.Add(playerRotation);
        RecordingManager.cameraRotationQuaternions.Add(cameraRotation);

        frame++;
    }

    void Update()
    {
        if (RecordingManager.gunIsShot == true)
        {
            RecordingManager.shootTimings.Add(frame);
            RecordingManager.gunIsShot = false;
        }
    }
}
