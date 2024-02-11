using System.Collections.Generic;

public class WorldEventManager
{
    private List<GlobalEvent> globalEvents;

    public WorldEventManager()
    {
        globalEvents = new List<GlobalEvent>();
        // Populate with potential global events
    }

    public void TriggerGlobalEvent()
    {
        // Randomly or conditionally trigger a global event
        int index = UnityEngine.Random.Range(0, globalEvents.Count);
        GlobalEvent globalEvent = globalEvents[index];
        globalEvent.Execute();
    }

    // Additional global event-related methods...
}

public class GlobalEvent
{
    

    public void Execute()
    {
        // Logic to apply the global event's effects to all kingdoms
    }

    // ... Other methods ...
}