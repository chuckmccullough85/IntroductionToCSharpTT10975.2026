using Location;

namespace Payroll
{
    public class Employee : HumanResource
    {
        const float TAX_RATE = .0765f;
        private float _salary;
        private float _ytdSalary;
        private float _ytdTax;

        public Employee(string name, int id, float salary)
            : this(name, id, salary, DateTime.Today)
        { }
        public Employee(string name, int id, float salary, DateTime dateOfBirth)
        {
            _ytdSalary = 0;
            _ytdTax = 0;
            Name = name;
            DateOfBirth = dateOfBirth;
            Id = id;
            Salary = salary;
        }

        public Address? WorkAddress { get; set; }

        public float Salary
        {
            get => _salary; 
            set
            {
                if (value is < 50 or > 1000) throw new ArgumentException("Invalid Salary");
                _salary = value;
            }
        }
        public float YtdSalary => _ytdSalary;
        public float YtdTax => _ytdTax;

        public override float Pay()
        {
            var tax = Salary * TAX_RATE;
            _ytdTax += tax;
            _ytdSalary += Salary;
            return Salary - tax;
        }

        public override string? ToString()
        {
            var txt = $@"{Name} [{Id}] dob: {DateOfBirth:d} makes {Salary:c}
YTD Earnings {YtdSalary:c}, YTD Taxes {YtdTax:c}";
            if (HomeAddress != null) txt = $"{txt}\nHome:\n{HomeAddress.ToString()}";
            if (WorkAddress != null) txt = $"{txt}\nWork:\n{WorkAddress.ToString()}";
            return txt;
        }

    }

}