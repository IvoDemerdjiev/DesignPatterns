namespace StrategyDP
{
    using System;
    using System.Collections.Generic;
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //Default is Quick Sort
            list.Sort();
            Console.WriteLine("QuickSorted list ");
        }
    }
}