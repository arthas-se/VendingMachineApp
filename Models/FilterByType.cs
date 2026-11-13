using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public class FilterByType : IFilterAlgorithm
{
    public string Name => "Drink Class Type";

    public List<OrderHistoryItem> Filter(List<OrderHistoryItem> history, string criteria)
    {
        if (string.IsNullOrWhiteSpace(criteria)) return history;
        return history.Where(h => h.Drink.GetType().Name.Equals(criteria, System.StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
