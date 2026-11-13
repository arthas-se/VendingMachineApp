using System;
using System.Collections.Generic;
using System.Text;

namespace Task2;

public interface IFilterAlgorithm
{
    string Name { get; }
    List<OrderHistoryItem> Filter(List<OrderHistoryItem> history, string criteria);
}
