using System.Collections.Generic;
using ULTRAReplay.Replay.Events;

namespace ULTRAReplay.Replay;

public class ReplayFrame
{
    public float delta;

    public List<IReplayEvent> events = [];
}