using System;
using System.Collections.Generic;

namespace Task2;

public class Supplier
{
    public string Name { get; set; }
    public Address Address { get; }
    public Dictionary<string, int> Resources { get; } = new Dictionary<string, int>();

    public Supplier(string name, string city, string street, string buildingNumber,
                    Dictionary<string, int>? initialResources = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Name = name;
        Address = new Address(city, street, buildingNumber);

        if (initialResources != null)
        {
            foreach (KeyValuePair<string, int> item in initialResources)
            {
                Resources[item.Key] = item.Value;
            }
        }
    }
    public Dictionary<string, int> ProvideResources(Dictionary<string, int> requestedAmounts)
    {
        ArgumentNullException.ThrowIfNull(requestedAmounts);

        var provided = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> request in requestedAmounts)
        {
            if (request.Value <= 0)
                continue;

            if (!Resources.TryGetValue(request.Key, out int available) || available <= 0)
                continue;

            int amount = Math.Min(request.Value, available);

            Resources[request.Key] = available - amount;
            provided[request.Key] = amount;
        }

        return provided;
    }
}
