using System.Collections.Generic;
using UnityEngine;

namespace ULTRAReplay;

class Replayer : MonoBehaviour
{
    int i = 0;
    void Update()
    {
        if(i < RecordingManager.playerPositionVectors.Count)
        {
            gameObject.transform.position = RecordingManager.playerPositionVectors.ToArray()[i];
            i++;
        } else
        {
            RecordingManager.playerPositionVectors = new List<Vector3> { };
            Destroy(gameObject);
        }
    }
}