using ULTRAReplay.Master.Data;

namespace ULTRAReplay.Master.Events;

public interface IReplayEvent
{
    EventTypes EventType
    {
        get;
    }

    ReplayData rawData
    {
        get;
    }
}