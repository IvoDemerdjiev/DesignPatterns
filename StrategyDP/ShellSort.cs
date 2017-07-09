namespace StrategyDP
{
    using System;
    using System.Collections.Generic;

    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //TO DO add ShellSort
            list.Sort();
            Console.WriteLine("ShellSorted list ");
        }
    }
}