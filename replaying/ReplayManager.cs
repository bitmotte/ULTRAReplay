using UnityEngine;

namespace ULTRAReplay;

static class ReplayManager
{
    static GameObject MakeReplayPlayer()
    {
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

        return replayPlayer;
    }
    
    public static void ReplayRecording()
    {
        GameObject replayPlayer = MakeReplayPlayer();
        
        replayPlayer.AddComponent<Replayer>();
    }
}