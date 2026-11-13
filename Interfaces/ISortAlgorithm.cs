using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public interface ISortAlgorithm
{
    string Name { get; }
    List<OrderHistoryItem> SortAsc(List<OrderHistoryItem> history);
    List<OrderHistoryItem> SortDesc(List<OrderHistoryItem> history);
}
