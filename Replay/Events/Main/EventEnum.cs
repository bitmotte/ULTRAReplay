using System;

namespace ULTRAReplay.Replay.Events;

public enum EventTypes
{
    FullTestEvent,
    TinyTestEvent,
    PlayerPositionEvent,
}

public static class EventEnum
{
    public static string EventName(EventTypes type)
    {
        switch (type)
        {
            case EventTypes.PlayerPositionEvent:
                return "PlayerPos";
            case EventTypes.FullTestEvent:
                return "FullTest";
            case EventTypes.TinyTestEvent:
                return "TinyTest";
            default:
                return "???";
        }
    }
}