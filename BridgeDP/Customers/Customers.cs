namespace BridgeDP
{
    using System;

    public class Customers : CustomersBase
    {
        public Customers(string group) 
            : base(group)
        {
        }

        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
