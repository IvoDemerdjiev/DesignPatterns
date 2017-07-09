namespace MementoDP
{
    public class ProspectMemory
    {
        private Memento memento;

        // Property
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}