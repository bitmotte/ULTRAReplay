using System.Collections;
using System.Text;
using BepInEx.Logging;
using ULTRAReplay.Record;
using UnityEngine;

namespace ULTRAReplay.CheatsDebugger;

public class DebugUpdater : MonoBehaviour
{
    public ICheat debugCheat;
    public MasterRecorder recorder;
    static readonly ManualLogSource log = Plugin.Logger;

    void Awake()
    {
        GameObject recorderObject = new("ULTRAReplay Recorder");
        recorderObject.transform.parent = null;
        recorder = recorderObject.AddComponent<MasterRecorder>();
    }

    void Update()
    {
        MonoSingleton<CheatsManager>.Instance.RenderCheatsInfo();
        StringBuilder builder = new(MonoSingleton<CheatsController>.Instance.cheatsInfo.text);
        builder.AppendLine(recorder.timeline.frames.Count.ToString() + " " + recorder.timeline.frames[recorder.timeline.frames.Count - 1].delta.ToString());
        
        MonoSingleton<CheatsController>.Instance.cheatsInfo.text = builder.ToString();
    }
}