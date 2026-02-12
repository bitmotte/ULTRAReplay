using ULTRAReplay.Master;
using UnityEngine;

namespace ULTRAReplay.Replay;

public class MasterReplayer : MonoBehaviour
{
    public static bool replaying = false;
    public ReplayTimeline timeline;
    public static MasterReplayer Instance; 

    void Awake()
    {
        Instance = this;
        replaying = true;
    }

    void Update()
    {
        //
    }
}