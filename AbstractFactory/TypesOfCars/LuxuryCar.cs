namespace AbstractFactory.TypesOfCars
{

    public abstract class LuxuryCar
    {
        public int luxuryLevel;

        protected LuxuryCar(int luxuryLevel)
        {
            this.luxuryLevel = LuxuryLevel;
        }   
        public int LuxuryLevel { get; set; }

    }
}
