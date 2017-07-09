namespace BridgeDP
{

    class BridgeMain
    {
        static void Main()
        {
            Customers customers = new Customers("Burgas");

            customers.Data = new CustomersData();

            customers.Show();
            customers.Next();
            customers.Add("Pesho Peshev");

            customers.ShowAll();
        }
    }
}
