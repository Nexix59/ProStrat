using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnitFactory
{
    public static Unit CreateUnit(string unitType)
    {
        // Factory method to create units based on type
        switch (unitType)
        {
            case "Knight":
                return new Unit { unitName = "Knight", attackPower = 150, defensePower = 100, maintenanceCost = 25, recruitmentCost = 100, requiredPopulation = 10 };
            // Add cases for other unit types
            default:
                return null;
        }
    }
}
