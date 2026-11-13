using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Task2;

public class Water : IDrink
{
    [JsonPropertyOrder(-3)]
    public string Name { get; set; }

    [JsonPropertyOrder(-2)]
    public decimal Price { get; set; }

    [JsonPropertyOrder(-1)]
    public int VolumeMl { get; set; }

    public bool IsCarbonated { get; set; }
    public bool WithIce { get; set; }

    public Water() { }

    public Water(string name, decimal price, int volumeMl, bool isCarbonated, bool withIce)
    {
        Name = name;
        Price = price;
        VolumeMl = volumeMl;
        IsCarbonated = isCarbonated;
        WithIce = withIce;
    }

    public Dictionary<string, int> GetRequiredIngredients()
    {
        var ingredients = new Dictionary<string, int>
        {
            { "Water", VolumeMl }
        };

        if (WithIce)
        {
            ingredients.Add("Ice", 30);
        }

        return ingredients;
    }

    public void Prepare()
    {

    }
}