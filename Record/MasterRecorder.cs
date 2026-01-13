using ULTRAReplay.Replay;
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
        timeline.frames.Add(newFrame);
    }

    void Update()
    {
        ReplayFrame newFrame = new();
        newFrame.delta = Time.deltaTime;
        timeline.frames.Add(newFrame);
    }
}