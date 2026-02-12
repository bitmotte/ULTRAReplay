using System.Collections.Generic;
using ULTRAReplay.Master.Events;

namespace ULTRAReplay.Master;

public class ReplayFrame
{
    public float delta;

    public List<IReplayEvent> events = [];
}