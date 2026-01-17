public class Employee
{
    const float TAX_RATE = .0765f;
    private string _name = string.Empty;
    private int _id;
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

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Address? HomeAddress { get; set; }
    public Address? WorkAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Id
    { get => _id; set => _id = value; }
    public float Salary
    {
        get => _salary;
        set
        {
            if (value < 50 || value > 1000)
                throw new ArgumentException("Salary must be between 50 and 1000");
            _salary = value;
        }
    }
    public float YtdSalary => _ytdSalary;
    public float YtdTax => _ytdTax;

    public override bool Equals(object? obj)
    {
        return obj is Employee employee &&
               _name == employee._name &&
               _id == employee._id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_name, _id);
    }

    public float Pay()
    {
        var tax = Salary * TAX_RATE;
        _ytdTax += tax;
        _ytdSalary += Salary;
        return Salary - tax;
    }

    public override string? ToString()
    {
        return $@"{Name} [{Id}] dob: {DateOfBirth:d} makes {Salary:c}
YTD Earnings {YtdSalary:c}, YTD Taxes {YtdTax:c}\n{HomeAddress}";
    }
}