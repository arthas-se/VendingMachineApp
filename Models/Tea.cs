using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Task2;

public enum TeaType
{
    Black,
    Green,
    Herbal
}

public class Tea : IDrink
{
    [JsonPropertyOrder(-3)]
    public string Name { get; set; }

    [JsonPropertyOrder(-2)]
    public decimal Price { get; set; }

    [JsonPropertyOrder(-1)]
    public int VolumeMl { get; set; }

    public TeaType Type { get; set; }
    public int SugarGram { get; set; }

    public Tea() { }

    public Tea(string name, decimal price, int volumeMl, TeaType type, int sugarGram = 0)
    {
        Name = name;
        Price = price;
        VolumeMl = volumeMl;
        Type = type;
        SugarGram = sugarGram;
    }

    public Dictionary<string, int> GetRequiredIngredients()
    {
        var ingredients = new Dictionary<string, int>
        {
            { "Water", VolumeMl },
            { $"TeaBag_{Type}", 1 }
        };

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