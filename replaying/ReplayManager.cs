using UnityEngine;

namespace ULTRAReplay;

static class ReplayManager
{
    public static void ReplayRecording()
    {
        GameObject replayPlayer = new("replay player");
        MeshRenderer meshRenderer = replayPlayer.AddComponent<MeshRenderer>();
        MeshFilter meshFilter = replayPlayer.AddComponent<MeshFilter>();
        meshFilter.mesh = MeshMaker.CreateCubeMesh();

        replayPlayer.AddComponent<Replayer>();
    }
}