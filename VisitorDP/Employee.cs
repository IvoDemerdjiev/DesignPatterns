namespace VisitorDP
{
    public class Employee : Element
    {
        private string name;
        private double income;
        private int vacationDays;

        // Constructor
        public Employee(string name, double income,
          int vacationDays)
        {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }

        // Gets or sets the name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Gets or sets income
        public double Income
        {
            get { return income; }
            set { income = value; }
        }

        // Gets or sets number of vacation days
        public int VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}