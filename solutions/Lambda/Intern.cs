namespace Payroll;

public class Intern : HumanResource
{
    public Intern (string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override float Pay() => 50;
    public override string ToString() => $"Intern {Name} ({Id})";

}