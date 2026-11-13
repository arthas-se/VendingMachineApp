using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Task2;

public class Coffee : IDrink
{
    [JsonPropertyOrder(-3)]
    public string Name { get; set; }

    [JsonPropertyOrder(-2)]
    public decimal Price { get; set; }

    [JsonPropertyOrder(-1)]
    public int VolumeMl { get; set; }

    public int CoffeeBeansGram { get; set; }
    public int MilkVolumeMl { get; set; }
    public int SugarGram { get; set; }

    public Coffee() { }

    public Coffee(string name, decimal price, int volumeMl, int coffeeBeansGram, int milkVolumeMl = 0, int sugarGram = 0)
    {
        Name = name;
        Price = price;
        VolumeMl = volumeMl;
        CoffeeBeansGram = coffeeBeansGram;
        MilkVolumeMl = milkVolumeMl;
        SugarGram = sugarGram;
    }

    public Dictionary<string, int> GetRequiredIngredients()
    {
        var ingredients = new Dictionary<string, int>
        {
            { "Water", VolumeMl },
            { "CoffeeBeans", CoffeeBeansGram }
        };

        if (MilkVolumeMl > 0)
        {
            ingredients.Add("Milk", MilkVolumeMl);
        }

        if (SugarGram > 0)
        {
            ingredients.Add("Sugar", SugarGram);
        }

        return ingredients;
    }

    public void Prepare()
    {

    }
}