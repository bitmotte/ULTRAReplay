using ULTRAReplay.Master.Data;

namespace ULTRAReplay.Master.Events;

public class InitEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.InitEvent;

    public ReplayData data = new([], [], [], ["Init"]);
    public ReplayData rawData => data;
}