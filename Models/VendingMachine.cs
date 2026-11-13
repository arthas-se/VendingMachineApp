using System;
using System.Collections.Generic;

namespace Task2;

public enum VendingMachineButtons
{
    Espresso,
    Latte,
    Cappuccino,
    BlackTea,
    GreenTea,
    WaterStill,
    WaterSparkling
}

public class VendingMachine
{
    public Address Address { get; }
    public Dictionary<string, int> Contents { get; } = new Dictionary<string, int>();
    public PriceCalculationStrategy PriceStrategy { get; set; } = PriceStrategies.StandardPrice;

    public event Action<string>? OnResourceShortage;

    public VendingMachine(string city, string street, string buildingNumber)
    {
        Address = new Address(city, street, buildingNumber);
    }

    public delegate IDrink DrinkFactory();

    private IDrink? VerifyDrink(VendingMachineButtons btn)
    {
        DrinkFactory? factory = btn switch
        {
            VendingMachineButtons.Espresso => () => new Coffee("Espresso", 35m, 35, coffeeBeansGram: 9),
            VendingMachineButtons.Latte => () => new Coffee("Latte", 55m, 150, coffeeBeansGram: 9, milkVolumeMl: 150, sugarGram: 5),
            VendingMachineButtons.Cappuccino => () => new Coffee("Cappuccino", 50m, 120, coffeeBeansGram: 9, milkVolumeMl: 100),
            VendingMachineButtons.BlackTea => () => new Tea("Black Tea", 25m, 200, TeaType.Black),
            VendingMachineButtons.GreenTea => () => new Tea("Green Tea", 25m, 200, TeaType.Green),
            VendingMachineButtons.WaterStill => () => new Water("Still Water", 15m, 250, isCarbonated: false, withIce: false),
            VendingMachineButtons.WaterSparkling => () => new Water("Sparkling Water", 15m, 250, isCarbonated: true, withIce: true),
            _ => null
        };

        return factory?.Invoke();
    }

    private List<string> FindShortages(IDrink drink)
    {
        var shortages = new List<string>();

        foreach (KeyValuePair<string, int> item in drink.GetRequiredIngredients())
        {
            Contents.TryGetValue(item.Key, out int inStock);

            if (item.Value > inStock)
            {
                shortages.Add($"{item.Key} (need {item.Value}, have {inStock})");
            }
        }

        return shortages;
    }

    private void WriteOffRequirements(IDrink drink)
    {
        var required = drink.GetRequiredIngredients();

        foreach (KeyValuePair<string, int> item in required)
        {
            Contents[item.Key] -= item.Value;
        }
    }

    private void PrepareDrink(IDrink drink)
    {
        drink.Prepare();
    }

    public IDrink? HandleClient(VendingMachineButtons btn)
    {
        IDrink? currDrink = VerifyDrink(btn);

        if (currDrink == null)
            throw new Exception("Invalid drink!");

        List<string> shortages = FindShortages(currDrink);

        if (shortages.Count > 0)
        {
            OnResourceShortage?.Invoke($"Not enough resources for {currDrink.Name}: {string.Join(", ", shortages)}");
            return null;
        }

        WriteOffRequirements(currDrink);
        PrepareDrink(currDrink);
        currDrink.Price = PriceStrategy(currDrink);

        return currDrink;
    }
}
