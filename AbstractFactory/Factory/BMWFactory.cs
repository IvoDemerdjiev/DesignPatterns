namespace AbstractFactory.Factory
{
    using BMWSerias;
    using TypesOfCars;

    public class BMWFactory : CarFactory
    {
        public override LuxuryCar CreatelLuxuryCar()
        {
            return new Seria7(6);
        }

        public override SportCar CreatesSportsCar()
        {
            return new SeriaI(280);
        }

        public override JeepCar CreateJeepCar()
        {
            return new SeriaX(8);
        }
    }
}
