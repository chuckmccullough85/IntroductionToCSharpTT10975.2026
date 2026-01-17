
using Location;

namespace Payroll
{
    public class Organization
    {
        public Organization(string name, string taxid) 
        {
            Name = name;
            TaxId= taxid;
        }

        public string Name { get; set; }
        public string TaxId { get; set; }
        public Address? Address { get; set; }    
        public List<HumanResource> Employees { get; set; } = new();

        public void Hire (HumanResource employee) => Employees.Add(employee);
        public void Terminate(HumanResource employee) => Employees.Remove(employee);
        public float Pay()
        {
            float total = 0;
            foreach (var employee in Employees)
                total += employee.Pay();
            return total;
        }
    }
}
