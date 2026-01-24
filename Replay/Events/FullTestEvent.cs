using ULTRAReplay.Replay.Data;

namespace ULTRAReplay.Replay.Events;

public class FullTestEvent : IReplayEvent
{
    public EventTypes EventType => EventTypes.FullTestEvent;

    public ReplayData data = new([1,2,3], [0.333f,0.666f,1f], [new(-1,-1,-1),new(0,0,0),new(1,1,1)], ["Lame","Rad","Wacky"]);
    public ReplayData rawData => data;
}