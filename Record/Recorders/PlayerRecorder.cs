using ULTRAReplay.Replay.Data;
using UnityEngine;

namespace ULTRAReplay.Record.Recorders;

public class PlayerRecorder : MonoBehaviour
{
    void Update()
    {
        MasterRecorder.Instance.AddEvent(Replay.Events.EventTypes.PlayerPositionEvent, new([],[],[transform.position],[]));
    }
}