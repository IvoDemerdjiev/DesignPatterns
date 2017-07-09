namespace AbstractFactory.MercedesSerias
{
    using TypesOfCars;

    public class GTS : SportCar
    {
        public GTS(int topSpeed) : base(topSpeed)
        {
            base.TopSpeed = topSpeed;
        }
    }
}
