namespace AbstractFactory.MercedesSerias
{
    using TypesOfCars;

    public class MClass : JeepCar
    {
        public MClass(int numOfSeats) : base(numOfSeats)
        {
            base.NumOfSeats = numOfSeats;
        }
    }
}
