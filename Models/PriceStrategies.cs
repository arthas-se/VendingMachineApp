using System;

namespace Task2;

public delegate decimal PriceCalculationStrategy(IDrink drink);

public static class PriceStrategies
{
    private const decimal FridayDiscountRate = 0.10m;

    public static decimal StandardPrice(IDrink drink)
    {
        return drink.Price;
    }

    public static decimal FridayDiscountPrice(IDrink drink)
    {
        decimal price = StandardPrice(drink);

        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
        {
            price -= price * FridayDiscountRate;
        }

        return Math.Round(price, 2);
    }
}
