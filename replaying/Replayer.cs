using System.Collections.Generic;
using UnityEngine;

namespace ULTRAReplay;

class Replayer : MonoBehaviour
{
    int i = 0;
    void Awake() {
        ReplayManager.cameraPivot = gameObject.transform.GetChild(0).gameObject;
    }
    void FixedUpdate()
    {
        if(i < RecordingManager.playerPositionVectors.Count)
        {
            gameObject.transform.position = RecordingManager.playerPositionVectors.ToArray()[i];
            gameObject.transform.rotation = RecordingManager.playerRotationQuaternions.ToArray()[i];
            ReplayManager.cameraPivot.transform.rotation = RecordingManager.cameraRotationQuaternions.ToArray()[i];
            
            foreach (int frame in RecordingManager.shootTimings)
            {
                if (i == frame)
                {
                    ReplayManager.replayRevolver.ShootPrimary();
                }
            }
            i++;
        } else
        {
            RecordingManager.playerPositionVectors = [];
            RecordingManager.playerRotationQuaternions = [];
            RecordingManager.cameraRotationQuaternions = [];
            Destroy(gameObject);
        }
    }
}