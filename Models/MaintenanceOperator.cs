using System;
using System.Collections.Generic;

namespace Task2;

public class MaintenanceOperator
{
    public string FullName { get; set; }
    public Supplier Supplier { get; set; }
    public VendingMachine AssignedMachine { get; set; }
    public Dictionary<string, int> TargetLevels { get; } = new Dictionary<string, int>
    {
        { "Water", 2000 },
        { "CoffeeBeans", 300 },
        { "Milk", 1000 },
        { "TeaBag_Black", 20 },
        { "TeaBag_Green", 20 },
        { "Sugar", 500 },
        { "Ice", 200 }
    };

    public MaintenanceOperator(string fullName, Supplier supplier, VendingMachine assignedMachine)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(fullName);
        ArgumentNullException.ThrowIfNull(supplier);
        ArgumentNullException.ThrowIfNull(assignedMachine);

        FullName = fullName;
        Supplier = supplier;
        AssignedMachine = assignedMachine;
    }
    public Dictionary<string, int> ReplenishContents(VendingMachine machine)
    {
        ArgumentNullException.ThrowIfNull(machine);

        Dictionary<string, int> request = BuildRequest(machine);
        Dictionary<string, int> delivered = Supplier.ProvideResources(request);

        foreach (KeyValuePair<string, int> item in delivered)
        {
            machine.Contents[item.Key] = machine.Contents.TryGetValue(item.Key, out int current)
                ? current + item.Value
                : item.Value;
        }

        return delivered;
    }

    private Dictionary<string, int> BuildRequest(VendingMachine machine)
    {
        var request = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> target in TargetLevels)
        {
            machine.Contents.TryGetValue(target.Key, out int current);

            int missing = target.Value - current;
            if (missing > 0)
            {
                request[target.Key] = missing;
            }
        }

        return request;
    }
}
