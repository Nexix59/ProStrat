using UnityEngine;
using System.Collections.Generic;

public class EconomyManager : MonoBehaviour
{
    public int goldReserves;
    private List<City> cities;
    private List<Unit> units;

    public void InitializeEconomy(List<City> cities, List<Unit> units)
    {
        this.cities = cities;
        this.units = units;
    }

    public void UpdateEconomy()
    {
        CollectTaxes();
        CalculateTradeIncome();
        CalculateMaintenanceCosts();
        UpdateGoldReserves();
    }

    private void CollectTaxes()
    {
        foreach (City city in cities)
        {
            goldReserves += city.CalculateTaxes();
        }
    }

    private void CalculateTradeIncome()
    {
        // Placeholder logic for trade income
        int tradeIncome = 100; // Example value
        goldReserves += tradeIncome;
    }

    private void CalculateMaintenanceCosts()
    {
        int maintenanceCosts = 0;
        foreach (Unit unit in units)
        {
            maintenanceCosts += unit.maintenanceCost;
        }
        goldReserves -= maintenanceCosts;
    }

    private void UpdateGoldReserves()
    {
        // Placeholder logic for updating gold reserves
        if (goldReserves < 0)
        {
            Debug.LogError("The kingdom is bankrupt!");
            // Implement bankruptcy logic here
        }
    }

    public bool CanAfford(int cost)
    {
        return goldReserves >= cost;
    }

    public void SpendGold(int amount)
    {
        if (CanAfford(amount))
        {
            goldReserves -= amount;
        }
        else
        {
            Debug.LogError("Not enough gold to spend!");
        }
    }

    // ... Other methods related to economy management ...
}