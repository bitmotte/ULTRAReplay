using ULTRAReplay.Replay.Data;

namespace ULTRAReplay.Replay.Events;

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