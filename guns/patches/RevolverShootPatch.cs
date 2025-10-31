using HarmonyLib;
using ULTRAReplay;

[HarmonyPatch(typeof(Revolver), "Shoot")]
class Patch
{
    static void Postfix()
    {
        RecordingManager.gunIsShot = true;
    }
}