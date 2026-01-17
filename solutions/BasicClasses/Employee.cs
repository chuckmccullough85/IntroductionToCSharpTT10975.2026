
public class Employee
{
    public string _name;
    public int _id;
    public float _salary;
    public float _ytdSalary;
    public float _ytdTax;

    public Employee(string name, int id, float salary)
    {
        _name= name;
        _id= id;
        _salary= salary;
        _ytdSalary= 0;
        _ytdTax= 0;
    }

    public float Pay()
    {
        var tax = _salary * .0765f;
        _ytdTax += tax;
        _ytdSalary += _salary;
        return _salary - tax;
    }
}

