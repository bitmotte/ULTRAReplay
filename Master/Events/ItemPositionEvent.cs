using ULTRAReplay.Master.Data;

namespace ULTRAReplay.Master.Events;

public class ItemPositionEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.ItemPositionEvent;

    public ReplayData data = new([],[],[],[]);

    public ReplayData rawData => data;
}