using ULTRAReplay.Replay.Data;

namespace ULTRAReplay.Replay.Events;

public class PlayerPositionEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.PlayerPositionEvent;

    public ReplayData rawData => throw new System.NotImplementedException();
}