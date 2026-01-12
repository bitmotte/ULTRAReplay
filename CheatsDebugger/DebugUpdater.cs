using System.Collections;
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
        log.LogInfo("Hello");

        yield return new WaitForSeconds(.1f);

        StartCoroutine(Process());
    }
}