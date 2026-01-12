using UnityEngine;

namespace ULTRAReplay.CheatsDebugger;

internal class DebugCheat : ICheat
{
    private static GameObject updaterBody;

    public string LongName => "ULTRAReplay Debugger";

    public string Identifier => "ureplay.debugger";

    public string ButtonEnabledOverride => "Enabled";

    public string ButtonDisabledOverride => "Disabled";

    public string Icon => "ghost";

    public bool DefaultState => false;

    public StatePersistenceMode PersistenceMode => StatePersistenceMode.Persistent;

    public bool IsActive { get; private set; }

    public void Disable()
    {
        IsActive = false;
        Object.Destroy(updaterBody);
        Plugin.Logger.LogInfo("Debug Cheat Disabled");
    }

    public void Enable(CheatsManager manager)
    {
        IsActive = true;
        CreateUpdater(this);
        Plugin.Logger.LogInfo("Debug Cheat Enabled");
    }
    
    static void CreateUpdater(ICheat cheat)
    {
        updaterBody = new("ULTRAReplay Debug Updater");
        updaterBody.transform.parent = null;

        DebugUpdater updater = updaterBody.AddComponent<DebugUpdater>();
        updater.debugCheat = cheat;
    }
}

