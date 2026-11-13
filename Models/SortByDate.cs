using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public class SortByDate : ISortAlgorithm
{
    public string Name => "Date";

    public List<OrderHistoryItem> SortAsc(List<OrderHistoryItem> history)
    {
        return history.OrderBy(h => System.DateTime.Parse(h.OrderDate)).ToList();
    }

    public List<OrderHistoryItem> SortDesc(List<OrderHistoryItem> history)
    {
        return history.OrderByDescending(h => System.DateTime.Parse(h.OrderDate)).ToList();
    }
}
