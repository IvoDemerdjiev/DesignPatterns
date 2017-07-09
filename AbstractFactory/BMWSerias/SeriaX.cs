namespace AbstractFactory.BMWSerias
{
    using TypesOfCars;

    public class SeriaX : JeepCar
    {
        public SeriaX(int numOfSeats) : base(numOfSeats)
        {
            base.NumOfSeats = numOfSeats;
        }
    }
}
