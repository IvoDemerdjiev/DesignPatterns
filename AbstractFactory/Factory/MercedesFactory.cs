namespace AbstractFactory.Factory
{
    using MercedesSerias;
    using TypesOfCars;

    public class MercedesFactory : CarFactory
    {
        public override LuxuryCar CreatelLuxuryCar()
        {
            return new SClass(8);
        }

        public override SportCar CreatesSportsCar()
        {
            return new GTS(325);
        }

        public override JeepCar CreateJeepCar()
        {
            return new MClass(14);
        }
    }
}
