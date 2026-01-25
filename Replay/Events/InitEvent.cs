using ULTRAReplay.Replay.Data;

namespace ULTRAReplay.Replay.Events;

public class InitEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.InitEvent;

    public ReplayData data = new([], [], [], ["Init"]);
    public ReplayData rawData => data;
}