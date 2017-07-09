namespace MementoDP
{
    public class Memento
    {
        private string name;
        private string phone;
        private double budget;

        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this.name = name;
            this.phone = phone;
            this.budget = budget;
        }

        // Gets or sets name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Gets or set phone
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
    }
}