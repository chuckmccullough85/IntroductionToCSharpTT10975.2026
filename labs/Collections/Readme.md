| | |
| --------- | --------------------------- |
| Exercise Folder | Collections |
| Builds On | Generics |
| Time to complete | 15 minutes |

## Success Criteria
Your solution should:
- Replace `List<Employee>` with `HashSet<Employee>` in Organization
- Automatically reject duplicate employee hires (same id)
- Leverage Employee's `Equals` and `GetHashCode` for duplicate detection
- Maintain all existing Organization functionality with the new collection type

## Where to find the solution
See [solutions/Collections](../../solutions/Collections)

---


Hint - use a HashSet - Employee implement **Equals** and **GetHashCode** which is utilized by hash algorithms to detect duplicates.

---

:::spoiler
*Organization*
```c#
using Location;

namespace Payroll
{
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
}
```

*In Employee*
```c#
public override bool Equals(object? obj)
{
    return obj is Employee employee &&
           Name == employee.Name &&
           Id == employee.Id;
}

public override int GetHashCode()
{
    return HashCode.Combine(_name, _id);
}
```
:::