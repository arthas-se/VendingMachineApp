using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public class SortByPrice : ISortAlgorithm
{
    public string Name => "Price";

    public List<OrderHistoryItem> SortAsc(List<OrderHistoryItem> history)
    {
        return history.OrderBy(h => h.Drink.Price).ToList();
    }

    public List<OrderHistoryItem> SortDesc(List<OrderHistoryItem> history)
    {
        return history.OrderByDescending(h => h.Drink.Price).ToList();
    }
}
