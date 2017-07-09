namespace AbstractFactory.BMWSerias
{
    using TypesOfCars;

    public class SeriaI : SportCar
    {
        public SeriaI(int topSpeed) : base(topSpeed)
        {
            base.TopSpeed = topSpeed;
        }
    }
}
