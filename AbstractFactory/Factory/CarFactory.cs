namespace AbstractFactory.Factory
{
    using TypesOfCars;

    public abstract class CarFactory
    {
        public abstract LuxuryCar CreatelLuxuryCar();

        public abstract SportCar CreatesSportsCar();

        public abstract JeepCar CreateJeepCar();
    }
}
