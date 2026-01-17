
public class Employee
{
    private string _name = string.Empty;
    private uint _id;
    private float _salary;
    private float _ytdSalary;
    private float _ytdTax;

    public Employee(string name, uint id, float salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
        _ytdSalary= 0;
        _ytdTax= 0;
    }
    public string Name 
    {
        get { return _name; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
                _name = value; 
        }
    }
    public uint Id 
    {
        get { return _id; }
        private set 
        { 
            _id = value; 
        }
    }
    public float Salary 
    {
        get { return _salary; }
        set 
        { 
            // pattern matching syntax (C# 7.0)
            // use "is" to start a pattern matching expression
            if (value is > 0 and < 5000)
                _salary = value; 
        }
    }
    public float YtdSalary 
    {
        get { return _ytdSalary; }
    }
    public float YtdTax 
    {
        get { return _ytdTax; }
    }

    public float Pay()
    {
        var tax = _salary * .0765f;
        _ytdTax += tax;
        _ytdSalary += _salary;
        return _salary - tax;
    }
}

