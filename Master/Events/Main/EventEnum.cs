using System;

namespace ULTRAReplay.Master.Events;

public enum EventTypes
{
    FullTestEvent,
    TinyTestEvent,
    InitEvent,
    ItemPositionEvent,
}

public static class EventEnum
{
    public static string EventName(EventTypes type)
    {
        switch (type)
        {
            case EventTypes.ItemPositionEvent:
                return "ItemPos";
            case EventTypes.InitEvent:
                return "Init";
            case EventTypes.FullTestEvent:
                return "FullTest";
            case EventTypes.TinyTestEvent:
                return "TinyTest";
            default:
                return "???";
        }
    }
}