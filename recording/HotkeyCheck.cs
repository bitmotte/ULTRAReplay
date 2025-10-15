using UnityEngine;

namespace ULTRAReplay;

class HotkeyCheck : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            if(RecordingManager.recording == true)
            {
                RecordingManager.recording = false;
                RecordingManager.StopRecording();
                Plugin.Logger.LogInfo("recording stopped");
                ReplayManager.ReplayRecording();
            } else
            {
                RecordingManager.recording = true;
                RecordingManager.StartRecording();
                Plugin.Logger.LogInfo("recording started");
            }
        }
    }
}