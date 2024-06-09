using System.Collections.Generic;

public class EspionageManager
{
    private Kingdom owner;
    private List<Spy> spies;

    public EspionageManager(Kingdom owner)
    {
        this.owner = owner;
        spies = new List<Spy>();
    }

    public void SendSpy(Kingdom target)
    {
        // Send a spy to infiltrate the target kingdom
    }

    public void ConductSabotage(Kingdom target)
    {
        // Attempt to sabotage a target kingdom's resources or military
    }

    public void GatherIntelligence(Kingdom target)
    {
        // Gather intelligence about the target kingdom's military or economy
    }

    // Additional espionage-related methods...
}

public class Spy
{
    public Kingdom home;
    public Kingdom target;
    public float successRate;

    // Spy-related methods...
}