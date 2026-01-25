using ULTRAReplay.Replay.Data;

namespace ULTRAReplay.Replay.Events;

public class PlayerPositionEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.PlayerPositionEvent;

    public ReplayData data = new([],[],[new(0,0,0)],[]);

    public ReplayData rawData => data;
}