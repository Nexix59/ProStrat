using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// The City class represents a city within the kingdom.
public class City
{
    public string cityName;
    public int population;
    public float taxRate;
    public float growthRate;



    public int CalculateTaxes()
    {
        return Mathf.FloorToInt(population * taxRate);
    }

    public void GrowPopulation()
    {
        population += Mathf.FloorToInt(population * growthRate);
    }


     

    

}
