using UnityEngine;
using ULTRAKILL;
using System.Collections.Generic;

namespace ULTRAReplay;

static class RecordingManager
{
    static public GameObject player;
    static public List<Vector3> playerPositionVectors = new List<Vector3> {};
    static GameObject recorder;

    public static void StartRecording()
    {
        Plugin.Logger.LogInfo("Recording Started");
        player = GameObject.Find("Player");
        recorder = new GameObject();

        recorder.AddComponent<Recorder>();
    }
}