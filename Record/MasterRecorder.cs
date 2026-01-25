using System;
using ULTRAReplay.Record.Recorders;
using ULTRAReplay.Replay;
using ULTRAReplay.Replay.Data;
using ULTRAReplay.Replay.Events;
using UnityEngine;

namespace ULTRAReplay.Record;

public class MasterRecorder : MonoBehaviour
{
    public static bool recording = false;
    public ReplayTimeline timeline;
    public ReplayFrame newFrame;
    public static MasterRecorder Instance; 

    void Awake()
    {
        Instance = this;
        timeline = new();
        recording = true;

        newFrame = new();
        newFrame.delta = Time.deltaTime;
        newFrame.events.Add(new InitEvent());
        //this is probably fine
        timeline.frames.Add(newFrame);
        timeline.frames.Add(newFrame);
        timeline.frames.Add(newFrame);
        timeline.frames.Add(newFrame);
        timeline.frames.Add(newFrame);
        timeline.frames.Add(newFrame);

        AddRecorder(GameObject.Find("Player"), Recorders.PlayerRecorder);
    }

    void Update()
    {
        newFrame = new();
        newFrame.delta = Time.deltaTime;
        timeline.frames.Add(newFrame);
    }

    public enum Recorders
    {
        PlayerRecorder
    }

    public void AddRecorder(GameObject toRecord, Recorders recorder)
    {
        switch (recorder)
        {
            case Recorders.PlayerRecorder:
                toRecord.AddComponent<PlayerRecorder>();
                break;
            default:
                Plugin.Logger.LogInfo("No recorder given");
                break;
        }
    }

    public void AddEvent(EventTypes type, ReplayData data)
    {
        if(recording == true)
        {
            PlayerPositionEvent newEvent = new PlayerPositionEvent();
            newEvent.data = data;
            newFrame.events.Add(newEvent);
        }
    }
    
}