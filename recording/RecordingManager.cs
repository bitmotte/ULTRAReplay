using UnityEngine;
using System.Collections.Generic;

namespace ULTRAReplay;

static class RecordingManager
{
    static public GameObject player;
    static public List<Vector3> playerPositionVectors = new List<Vector3> { };
    static GameObject recorder;
    static GameObject checker;

    static public bool recording = false;

    public static void InitializeHotkeyCheck()
    {
        checker = new();
        checker.AddComponent<HotkeyCheck>();
        player = GameObject.Find("Player");
    }

    public static void StartRecording()
    {
        Plugin.Logger.LogInfo("Recording Started");
        recorder = new();

        recorder.AddComponent<Recorder>();
    }

    public static void StopRecording()
    {
        recorder = null;
    }
}