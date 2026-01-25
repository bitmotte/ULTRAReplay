using System.Collections.Generic;
using System.Text;
using BepInEx.Logging;
using ULTRAReplay.Record;
using ULTRAReplay.Replay.Events;
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
        
        for (int i = 1; i < 4; i++)
        {
            //!!!
            string numAndDeltaLine = "";
            numAndDeltaLine += "f : ";
            int frameCount = recorder.timeline.frames.Count - i;
            numAndDeltaLine += frameCount.ToString();
            numAndDeltaLine += " d : ";
            numAndDeltaLine += recorder.timeline.frames[frameCount - i].delta.ToString();
    
            builder.AppendLine(numAndDeltaLine);
    
            //!!!
            string eventCountLine = "  ";
            eventCountLine += recorder.timeline.frames[frameCount - i].events.Count;
            eventCountLine += " events :";
            builder.AppendLine(eventCountLine);
            
            //!!!
            foreach (IReplayEvent replayEvent in recorder.timeline.frames[frameCount - i].events)
            {
                string eventLine = "    ";
                eventLine += EventEnum.EventName(replayEvent.EventType);
                eventLine += " :";
    
                builder.AppendLine(eventLine);
    
                //!!!
                foreach (int integer in replayEvent.rawData.integers)
                {
                    string intLine = "      ";
                    intLine += integer.ToString();
    
                    builder.AppendLine(intLine);
                }
    
                //!!!
                foreach (float floatingPoint in replayEvent.rawData.floats)
                {
                    string floatLine = "      ";
                    floatLine += floatingPoint.ToString();
    
                    builder.AppendLine(floatLine);
                }
    
                //!!!
                foreach (Vector3 vector in replayEvent.rawData.vector3s)
                {
                    string vectorLine = "      ";
                    int max = 5;
                    if(vector.x.ToString().Length > max)
                    {
                        vectorLine += vector.x.ToString().Substring(0,max);
                    } else
                    {
                        vectorLine += vector.x.ToString();
                    }
                    vectorLine += " ";
                    
                    if(vector.y.ToString().Length > max)
                    {
                        vectorLine += vector.y.ToString().Substring(0,max);
                    } else
                    {
                        vectorLine += vector.y.ToString();
                    }
                    vectorLine += " ";

                    if(vector.z.ToString().Length > max)
                    {
                        vectorLine += vector.z.ToString().Substring(0,max);
                    } else
                    {
                        vectorLine += vector.z.ToString();
                    }
    
                    builder.AppendLine(vectorLine);
                }
    
                //!!!
                foreach (string stringed in replayEvent.rawData.strings)
                {
                    string stringLine = "      ";
                    stringLine += stringed;
    
                    builder.AppendLine(stringLine);
                }

                builder.AppendLine("");
            }
        }


        
        MonoSingleton<CheatsController>.Instance.cheatsInfo.text = builder.ToString();
    }
}