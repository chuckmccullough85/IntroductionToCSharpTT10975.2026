using Locations;

namespace Payroll;

public class Organization
{
    public Organization(string name, string taxid) 
    {
        Name = name;
        TaxId= taxid;
        Employees = new ();
    }

    public string Name { get; set; }
    public string TaxId { get; set; }
    public Address? Address { get; set; }    
    public HashSet<Employee> Employees { get; set; }

    public void Hire (Employee employee) => Employees.Add(employee);
    public void Terminate(Employee employee) => Employees.Remove(employee);
    public float Pay()
    {
        float total = 0;
        foreach (var employee in Employees)
            total += employee.Pay();
        return total;
    }
}