using UnityEngine;
using System.Collections.Generic;

public class Kingdom : MonoBehaviour
{
    public string kingdomName;
    public Color kingdomColor;
    public EconomyManager economyManager;
    public List<City> cities;
    public List<Unit> units;

    void Start()
    {
        economyManager = GetComponent<EconomyManager>();
        if (economyManager == null)
        {
            Debug.LogError("EconomyManager component not found on the kingdom GameObject!");
        }

        // Initialize cities and units with example data
        cities = new List<City>
        {
            new City { cityName = "Capital", population = 10000, taxRate = 0.2f, growthRate = 0.01f },
            // Add more cities as needed
        };

        units = new List<Unit>
        {
            // Units can be added dynamically through recruitment
        };

        // Pass references to the EconomyManager
        economyManager.InitializeEconomy(cities, units);
    }

    void Update()
    {
        // Update logic for the Kingdom
        economyManager.UpdateEconomy();
        UpdateCities();
        // Additional update logic for diplomacy, war, etc.
    }

    void UpdateCities()
    {
        foreach (City city in cities)
        {
            city.GrowPopulation();
        }
    }

    public void RecruitUnit(string unitType, City city)
{
    // Recruitment logic based on unit type and city resources
    Unit newUnit = UnitFactory.CreateUnit(unitType);
    if (newUnit != null && economyManager.CanAfford(newUnit.recruitmentCost))
    {
        units.Add(newUnit);
        economyManager.SpendGold(newUnit.recruitmentCost);
        city.population -= newUnit.requiredPopulation;
    }
}

    // ... Other methods and logic for managing the kingdom ...
}