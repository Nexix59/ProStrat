using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Unit
{
    public string unitName;
    public int attackPower;
    public int defensePower;
    public int health;
    public int maintenanceCost;
    public int recruitmentCost;
    public int requiredPopulation;

    // Constructor, if needed
    public Unit()
    {
        // Initialize default values
    }

    // Methods for the Unit class
    public void Attack(Unit target)
    {
        // Implementation of attack
    }

    public void TakeDamage(int damage)
    {
        // Implementation of taking damage
    }

    private void Die()
    {
        // Implementation of dying
    }

    // ... Other properties and methods ...
}

