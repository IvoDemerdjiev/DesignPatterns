namespace AbstractFactory.MercedesSerias
{
    using TypesOfCars;

    public class SClass : LuxuryCar
    {
        public SClass(int luxaryLevel) : base(luxaryLevel)
        {
            base.LuxuryLevel = luxaryLevel;
        }
    }
}
