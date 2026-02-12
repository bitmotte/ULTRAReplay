using ULTRAReplay.Master.Data;
using UnityEngine;

namespace ULTRAReplay.Record.Recorders;

public class PlayerRecorder : MonoBehaviour
{
    void Update()
    {
        MasterRecorder.Instance.AddEvent(Master.Events.EventTypes.ItemPositionEvent, new([],[],[transform.position],["player"]));
    }
}