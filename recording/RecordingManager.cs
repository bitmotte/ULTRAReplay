using UnityEngine;
using System.Collections.Generic;

namespace ULTRAReplay;

static class RecordingManager
{
    static public GameObject player;
    static public GameObject camera;

    static public List<Vector3> playerPositionVectors = [];
    static public List<Quaternion> playerRotationQuaternions = [];
    static public List<Quaternion> cameraRotationQuaternions = [];

    static public List<int> shootTimings = [];
    static public bool gunIsShot;

    static GameObject recorder;
    static GameObject checker;

    static public bool recording = false;

    public static void InitializeHotkeyCheck()
    {
        checker = new();
        checker.AddComponent<HotkeyCheck>();
        player = GameObject.Find("Player");
        camera = player.transform.GetChild(4).gameObject;
    }

    public static void StartRecording()
    {
        Plugin.Logger.LogInfo("Recording Started");
        recorder = new();

        recorder.AddComponent<Recorder>();
    }

    public static void StopRecording()
    {
        GameObject.Destroy(recorder);
    }
}