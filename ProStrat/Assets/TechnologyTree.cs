using System.Collections.Generic;

public class TechnologyTree
{
    public List<Technology> technologies;

    public void ResearchTechnology(Technology tech)
    {
        // Check if prerequisites are met and if enough resources are available
        // If so, mark the technology as researched
    }
 public void UnlockFeatures(Technology tech)
    {
        if (tech.isResearched)
        {
            // Logic to unlock new units, buildings, or bonuses
        }
    }
    
    // Other methods...
}
    // Methods to check progress, unlock new units/buildings, etc.
