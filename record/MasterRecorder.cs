using UnityEngine;

namespace ULTRAReplay;

public class MasterRecorder : MonoBehaviour
{
    public bool Recording = false;

    void Update()
    {
        Plugin.Logger.LogInfo(Time.deltaTime);
    }
}