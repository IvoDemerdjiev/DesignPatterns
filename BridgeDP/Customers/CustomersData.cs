namespace BridgeDP
{
    using System;
    using System.Collections.Generic;

    public class CustomersData : DataObject
    {
        private List<string> customers = new List<string>();
        private int current = 0;

        public CustomersData()
        {
            // Loaded from a database 
            customers.Add("Ivan Ivanov");
            customers.Add("Gosho Geshev");
            customers.Add("Martin Martinov");
        }

        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }

        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void ShowAllRecords()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
    }
}
