using System.Linq;
using ULTRAReplay.Replay;
using ULTRAReplay.Replay.Events;
using UnityEngine;

namespace ULTRAReplay.Record;

public class MasterRecorder : MonoBehaviour
{
    public ReplayTimeline timeline;

    void Awake()
    {
        timeline = new();

        ReplayFrame newFrame = new();
        newFrame.delta = Time.deltaTime;
        newFrame.events.Add(new FullTestEvent());
        timeline.frames.Add(newFrame);
    }

    void Update()
    {
        ReplayFrame newFrame = new();
        newFrame.delta = Time.deltaTime;
        newFrame.events.Add(new FullTestEvent());
        timeline.frames.Add(newFrame);
    }
}