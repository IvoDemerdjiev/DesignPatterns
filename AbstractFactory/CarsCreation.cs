using System;

namespace AbstractFactory
{

    using Factory;
    using TypesOfCars;

    public class CarsCreation
    {
        private LuxuryCar luxuryCar;

        private SportCar sportCar;

        private JeepCar jeepCar;

        public CarsCreation(CarFactory factory)
        {
            this.luxuryCar = factory.CreatelLuxuryCar();
            this.sportCar = factory.CreatesSportsCar();
            this.jeepCar = factory.CreateJeepCar();
        }

        public override string ToString()
        {
            return string.Format("Top luxury Car:{0} luxury level" + Environment.NewLine
                +"Top speed car:{1}mp/h" + Environment.NewLine
                +"Biggest jeep:{2} max seats",luxuryCar.LuxuryLevel,sportCar.TopSpeed,jeepCar.NumOfSeats);
        }
    }
}
