using System.Collections;
using System.Text;
using BepInEx.Logging;
using UnityEngine;

namespace ULTRAReplay.CheatsDebugger;

public class DebugUpdater : MonoBehaviour
{
    public ICheat debugCheat;
    static readonly ManualLogSource log = Plugin.Logger;
    
    public void Awake()
    {
        StartCoroutine(Process());
    }

    IEnumerator Process()
    {
        yield return new WaitForSeconds(.1f);

        MonoSingleton<CheatsManager>.Instance.RenderCheatsInfo();
        StringBuilder builder = new(MonoSingleton<CheatsController>.Instance.cheatsInfo.text);
        //this is temporary
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        builder.AppendLine("frame delta event values");
        
        MonoSingleton<CheatsController>.Instance.cheatsInfo.text = builder.ToString();        

        StartCoroutine(Process());
    }
}