using UnityEngine;

namespace ULTRAReplay;

static class ReplayManager
{
    public static GameObject replayPlayer;
    public static ReplayRevolver replayRevolver;
    public static GameObject cameraPivot;
    public static Replayer replayer;

    static GameObject MakeReplayPlayer()
    {
        
        //guns
        
        GameObject replayPlayer = new("replay player");
        replayPlayer.transform.position = Vector3.zero;
        replayPlayer.AddComponent<MeshRenderer>();
        MeshFilter playerMeshFilter = replayPlayer.AddComponent<MeshFilter>();
        playerMeshFilter.mesh = MeshMaker.CreateCubeMesh();

        GameObject replayCameraPivot = new("replay camera pivot");
        replayCameraPivot.transform.SetParent(replayPlayer.transform);
        replayCameraPivot.transform.position = new Vector3(0, 1, 0);

        GameObject replayCamera = new("replay camera");
        replayCamera.transform.SetParent(replayCameraPivot.transform);
        replayCamera.AddComponent<MeshRenderer>();
        MeshFilter cameraMeshFilter = replayCamera.AddComponent<MeshFilter>();
        cameraMeshFilter.mesh = MeshMaker.CreateCubeMesh();
        replayCamera.transform.localScale = new Vector3(.5f, .5f, 1f);
        replayCamera.transform.position = new Vector3(0, 1, .5f);

        //guns

        GameObject replayRevolverObj = new("replayRevolver");
        replayRevolverObj.transform.SetParent(replayCamera.transform);
        replayRevolverObj.transform.localPosition = new();
        replayRevolver = replayRevolverObj.AddComponent<ReplayRevolver>();


        return replayPlayer;
    }
    
    public static void ReplayRecording()
    {
        replayPlayer = MakeReplayPlayer();
        
        replayer = replayPlayer.AddComponent<Replayer>();
    }
}