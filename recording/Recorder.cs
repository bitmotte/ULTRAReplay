using UnityEngine;

namespace ULTRAReplay;

class Recorder : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 playerPosition = RecordingManager.player.transform.position;
        Quaternion playerRotation = RecordingManager.player.transform.rotation;
        Quaternion cameraRotation = RecordingManager.camera.transform.rotation;
        RecordingManager.playerPositionVectors.Add(playerPosition);
        RecordingManager.playerRotationQuaternions.Add(playerRotation);
        RecordingManager.cameraRotationQuaternions.Add(cameraRotation);
    }
}
