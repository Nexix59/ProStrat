using System;
using System.Collections.Generic;

public class EventSystem
{
    public List<GameEvent> events;

    public void TriggerEvent(GameEvent gameEvent)
    {
        // Handle the event's effects on the kingdom
    }
}

public class GameEvent
{
    public string title;
    public string description;
    public Action effect;

    public GameEvent(string title, string description, Action effect)
    {
        this.title = title;
        this.description = description;
        this.effect = effect;
    }

    public void Execute()
    {
        effect?.Invoke();
    }
}