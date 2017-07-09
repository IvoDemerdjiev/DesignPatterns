namespace StrategyDP
{
    using System;
    using System.Collections.Generic;

    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //TO DO Merge
            list.Sort();
            Console.WriteLine("MergeSorted list ");
        }
    }
}