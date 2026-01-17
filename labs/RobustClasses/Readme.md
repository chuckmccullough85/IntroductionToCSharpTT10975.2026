## Overview
We add equality semantics to Employee & give the employee addresses. 

| | |
| --------- | --------------------------- |
| Exercise Folder | RobustClasses |
| Builds On | ClassMembers |
| Time to complete | 30 minutes |

---

## Success Criteria
Your solution should:
- Override `Equals` to compare employees by id (unique identifier)
- Override `GetHashCode` to be consistent with Equals implementation
- Override `ToString` to provide meaningful string representation
- Create `Address` class with proper properties (Street, City, State, Zip)
- Support nullable addresses on Employee (HomeAddress and WorkAddress)
- Demonstrate equality semantics with reference vs. value comparisons

## Where to find the solution
See [solutions/RobustClasses](../../solutions/RobustClasses)
## Instructions
Continue with the previous lab.

Employee inherits from **Object**.  Object provides methods *Equals* and *GetHashCode*.  These methods are technically accurate, but not personalized for our class.
### Steps
1. In *Program.cs*, create another employee object with the same name, id and salary as one of your existing objects.  Use an if statement to compare the identical employees
```C#
if (e1.Equals(e2)) ...
```
Then, assign e2 to e1 so that both variables refer to the same employee object in memory and try the comparison again.  What did you learn?

2. Override *Equals* and *GetHashCode* in the Employee class.  Use the *Quick actions...* menu to generate them for you.  Select the name and id fields
2. Now, run your program again - the 2 employee objects should be equal
2. Override ToString() - return a string containing the employee's name, id, salary, and YTD values
2. In the top level code, check out ToString by passing employee objects to WriteLine

---
### Part 2
An employee has an address - in fact, the employee has 2 addresses: work and home.  Let's define a new type that we can reuse for both addresses
1. Create a new class in your project named **Address**
1. The class will have these auto properties:
    - Street
    - Apt
    - City
    - State
    - Zip
1. Define a constructor that takes all 5 properties as arguments
1. Add 2 auto-properties to *Employee*, ```Address? HomeAddress... and Address? WorkAddress...``` (what does the ? mean)
1. Update ToString to include address info
1. Update Program.cs to set address info for some of your employees

---

:::spoiler
*Address*
```c#
public class Address
{
    public Address(string street, string? apt, string city, string state, string postalCode)
    {
        Street = street;
        Apt = apt;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    public string Street { get; set; }
    public string? Apt { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public override string ToString()
    => $"{Street}\n{Apt}\n{City}, {State} {PostalCode}";
}
```

*Employee*
```c#
public class Employee
{
    const float TAX_RATE = .0765f;
    private string _name;
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
```
:::
