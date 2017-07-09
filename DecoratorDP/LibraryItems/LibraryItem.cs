namespace DecoratorDP
{
    public abstract class LibraryItem
    {
        private int numberOfCopies;

        public int NumberOfCopies
        {
            get { return numberOfCopies; }
            set { numberOfCopies = value; }
        }

        public abstract void Display();
    }
}
