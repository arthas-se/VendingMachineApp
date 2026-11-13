using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public class FilterByName : IFilterAlgorithm
{
    public string Name => "Drink Name";

    public List<OrderHistoryItem> Filter(List<OrderHistoryItem> history, string criteria)
    {
        if (string.IsNullOrWhiteSpace(criteria)) return history;
        return history.Where(h => h.Drink.Name.Equals(criteria.Trim(), System.StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
