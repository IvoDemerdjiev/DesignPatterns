namespace AbstractFactory.BMWSerias
{
    using TypesOfCars;

    public class Seria7 : LuxuryCar
    {
        public Seria7(int luxuryLevel) : base(luxuryLevel)
        {
            base.LuxuryLevel = luxuryLevel;
        }
    }
}
