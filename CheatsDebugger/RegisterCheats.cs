using BepInEx.Logging;
using UnityEngine.SceneManagement;

namespace ULTRAReplay.CheatsDebugger;

class RegisterCheats
{
    static readonly ManualLogSource log = Plugin.Logger;

    public static void Register()
    {
        log.LogInfo("Registering Debug Cheat");
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    static void OnSceneLoad(Scene arg0, LoadSceneMode arg1)
    {
        CheatsManager manager = MonoSingleton<CheatsManager>.Instance;
        if(manager != null)
        {
            manager.RegisterCheat(new DebugCheat(), "debug");
        }
    }
}