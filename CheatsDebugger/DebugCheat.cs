using UnityEngine;

namespace ULTRAReplay.CheatsDebugger;

internal class DebugCheat : ICheat
{
    public string LongName => "ULTRAReplay Debugger";

    public string Identifier => "ureplay.debugger";

    public string ButtonEnabledOverride => "Enabled";

    public string ButtonDisabledOverride => "Disabled";

    public string Icon => "ghost";

    public bool DefaultState => false;

    public StatePersistenceMode PersistenceMode => StatePersistenceMode.Persistent;

    public bool IsActive => true;

    public void Disable()
    {
        Plugin.Logger.LogInfo("Debug Cheat Disabled");
        CreateUpdater(this);
    }

    public void Enable(CheatsManager manager)
    {
        Plugin.Logger.LogInfo("Debug Cheat Enabled");
        CreateUpdater(this);
    }
    
    static void CreateUpdater(ICheat cheat)
    {
        GameObject updaterBody = new("ULTRAReplay Debug Updater");
        updaterBody.transform.parent = null;

        DebugUpdater updater = updaterBody.AddComponent<DebugUpdater>();
        updater.debugCheat = cheat;
    }
}

