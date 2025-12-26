using ULTRAReplay;
using UnityEngine;

public class TempHotkeyCheck : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F4))
        {
            Plugin.Logger.LogInfo("Record");
        }
    }
}