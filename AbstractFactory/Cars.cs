using System;

namespace AbstractFactory
{
    using Factory;

    public class Cars
    {
        private static void Main()
        {
            // Create and run the African animal world
            CarFactory mercedes = new MercedesFactory();
            CarsCreation bendz = new CarsCreation(mercedes);
            Console.WriteLine(bendz);

            Console.WriteLine();

            CarFactory BMW = new BMWFactory();
            CarsCreation beamer = new CarsCreation(BMW);
            Console.WriteLine(beamer);

        }
    }
}
