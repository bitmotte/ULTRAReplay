using UnityEngine;

namespace ULTRAReplay;

class Recorder : MonoBehaviour
{
    void Update()
    {
        Vector3 playerPosition = RecordingManager.player.transform.position;
        RecordingManager.playerPositionVectors.Add(playerPosition);
    }
}
