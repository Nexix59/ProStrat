using System.Collections.Generic;

public class DiplomacyManager
{
    private Dictionary<Kingdom, DiplomaticStatus> diplomaticRelations;

    public enum DiplomaticStatus
    {
        Neutral,
        Ally,
        War,
        TradePact
    }

    public DiplomacyManager()
    {
        diplomaticRelations = new Dictionary<Kingdom, DiplomaticStatus>();
    }

    public void SetRelation(Kingdom kingdom, DiplomaticStatus status)
    {
        diplomaticRelations[kingdom] = status;
    }

    public DiplomaticStatus GetRelation(Kingdom kingdom)
    {
        if (diplomaticRelations.TryGetValue(kingdom, out DiplomaticStatus status))
        {
            return status;
        }
        return DiplomaticStatus.Neutral; // Default status if not set
    }

    // Methods for forming alliances, declaring war, etc.

    public void FormAlliance(Kingdom kingdom)
    {
        SetRelation(kingdom, DiplomaticStatus.Ally);
        // Additional logic for forming an alliance
    }

    // Method to declare war
    public void DeclareWar(Kingdom kingdom)
    {
        SetRelation(kingdom, DiplomaticStatus.War);
        // Additional logic for declaring war
    }
    
    // Method to negotiate peace
    public void NegotiatePeace(Kingdom kingdom)
    {
        SetRelation(kingdom, DiplomaticStatus.Neutral);
        // Additional logic for peace negotiation
    }
    
    // Other methods...
}
