namespace ULTRAReplay;

public class ReplayEventTemplate
{
    public int data;

    public void Replay()
    {
        Plugin.Logger.LogInfo($"Template event,data : {data}");
    }
}