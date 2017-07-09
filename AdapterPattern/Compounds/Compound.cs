namespace AdapterPattern.Compounds
{
    using System;

    public class Compound
    {
        protected string chemical;
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            this.chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", chemical);
        }
    }
}
