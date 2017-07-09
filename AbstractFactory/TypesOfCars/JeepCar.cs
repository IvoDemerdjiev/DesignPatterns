namespace AbstractFactory.TypesOfCars
{

    public class JeepCar
    {
        private int numOfSeats;

        protected JeepCar(int numOfSeats)
        {
            this.numOfSeats = NumOfSeats;
        }

        public int NumOfSeats { get; set; }
    }
}
