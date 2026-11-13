using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Task2;

[JsonDerivedType(typeof(Water), typeDiscriminator: "water")]
[JsonDerivedType(typeof(Coffee), typeDiscriminator: "coffee")]
[JsonDerivedType(typeof(Tea), typeDiscriminator: "tea")]
public interface IDrink
{
    [JsonPropertyOrder(-3)]
    string Name { get; set; }

    [JsonPropertyOrder(-2)]
    decimal Price { get; set; }

    [JsonPropertyOrder(-1)]
    int VolumeMl { get; set; }

    Dictionary<string, int> GetRequiredIngredients();
    void Prepare();
}
