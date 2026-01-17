## Overview
Save payroll data to disk and restore it when the application starts.

| | |
| --------- | --------------------------- |
| Exercise Folder | PaywizPersist |
| Builds On | PaywizEditEmp |
| Time to complete | 60 minutes

## Success Criteria
Your solution should:
- Change YTD properties to read-write with internal setters
- Create `PayableRecord` record type capturing all HR properties
- Create `OrganizationRecord` record type for serialization
- Implement `OrganizationSerializer.Serialize()` using JSON serialization
- Implement `OrganizationSerializer.Deserialize()` for file restoration
- Use LINQ Concat to combine multiple employee types during serialization
- Use switch expression with Classname to reconstruct correct employee types
- Verify persisted data by opening JSON file
- Support application restart with automatic data restoration

## Where to find the solution
See [solutions/PaywizPersist](../../solutions/PaywizPersist)

---

### Problem
In order to save the payroll data, we need to get all the data in a way that we can save the information.  The Organization is the root object that contains all the data.  However, the organization exposes the employees as *Payable* types which does not provide us with all the information.  We will also need to save what class the object is so that it can be recreated when the application starts.

### Solution
We will use a technique that is used by othe persistence frameworks.  We will create a type (`record`) that will contain the class name and the union of all the HR properties.  We will also create a type (`record`) that will represent the organization.

We will create methods to convert the *Organization* to our records and back.

### Employee
Our current employee class has read-only YTD properties.  In order to restore the YTD values, they will need to be read-write.  

1. Change the YTD properties to read-write.

```csharp
public float YtdSalary {get => _ytdSalary; internal set => _ytdSalary = value;}
public float YtdTax {get => _ytdTax; internal set => _ytdTax = value;}
```

### OrganizationSerializer
Create a new class named OrganizationSerializer.

### PayableRecord
In the same file as *OrganizationSerializer*, Create a record type that will contain the class name and the union of all the HR properties.

```csharp
record PayableRecord(
    int Id, string Classname, string Name, DateTime DateOfBirth, Address? HomeAddress, // HR
    float Salary, float YtdSalary, float YtdTax, Address? WorkAddress, // Employee
    float PayRate);
```

### OrganizationRecord
In the same file, create a record type that will contain the organization and a list of PayableRecords.

```csharp
record OrganizationRecord (string Name, string Id, IEnumerable<PayableRecord> Payables);
```

### OrganizationSerializer
1. Make the class static
2. Add a a method named Serialize that will save a JSON serialized organization to a file

```csharp
public static void Serialize(Organization org, string path)
```

3. Leverage LINQ to convert the payables into PayableRecords

```csharp
var payables = org.Employees
    .Where(e=>e is Employee)
    .Select(e => new PayableRecord((e as Employee)!))
```
The `Where` method returns a sequence of payables where the type is Employee.  The `Select` method will convert the Employee to a PayableRecord.
Don't add a semicolon (;) because we aren't done yet!

You might notice that we are constructing the *PayableRecord* with an employee object.  We need to create a constructor that will take an employee object and populate the properties.  Create a body for the *PayableRecord* and add the following constructor.

```csharp
public PayableRecord(Employee e) : this(
    e.Id, nameof(Employee), e.Name, e.DateOfBirth, e.HomeAddress,
    e.Salary, e.YtdSalary, e.YtdTax, e.WorkAddress, 0) { }
```

Now, select the contractors and concatenate them to the payables.

```csharp
.Concat(org.Employees
.Where(e=>e is Contractor)
.Select(c => new PayableRecord((c as Contractor)!)))
```     
Now, you write the code to `.Concat` the interns!

You will need to also add a constructor for the Contractor and Intern in the *PayableRecord*.

4. Create an OrganizationRecord and serialize it to a file

```csharp
var orgRecord = new OrganizationRecord(org.Name, org.TaxId, payables);
var json = JsonSerializer.Serialize(orgRecord, 
    new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText(path, json);
```

### Program.cs
After the UI has run, serialize the organization to a file.
If you don't include a path in the file name, the file will be saved in the *bin\Debug\net?.0* folder.  We defined a variable with the project path so that the file would be in the project folder.

```csharp
new MainMenu(org).Display();
OrganizationSerializer.Serialize(org, $@"{projPath}\PayrollData.json");
```

Run the application and hire some people.  Close the application and open the file.  The file should contain the organization and all the employees.

## Deserialization
Now that we have saved the organization, we need to restore it when the application starts.  We will create a method that will read the file and convert it back to an organization.

### OrganizationSerializer
1. Add a method named Deserialize that will read the file and convert it back to an organization.

```csharp
public static Organization? Deserialize(string path)
{
    var json = File.ReadAllText(path);
    var orgRecord = JsonSerializer.Deserialize<OrganizationRecord>(json);
    if (orgRecord == null) return null;
    var org = new Organization(orgRecord.Name, orgRecord.Id);
```

> Note - The JSON deserializer will not know which constructor to use in the PayableRecord.  We just need to add an attribute to the constructor that will tell the deserializer which constructor to use.  On the line before the record definition, add the following attribute.  The `[method:` part is required since the primary constructor is not a method.

```csharp
[method: JsonConstructor]
record PayableRecord(...
```

Now we have the organization.  We can loop through the orgRecord payables and create the correct employee type. We will use a switch statement to determine the type of employee.

```csharp
foreach (var pr in orgRecord.Payables)
{
    switch (pr.Classname)
    {
        case nameof(Employee):
            var e = new Employee(pr.Name, pr.Id, pr.Salary, pr.DateOfBirth);
            e.HomeAddress = pr.HomeAddress;
            e.WorkAddress = pr.WorkAddress;
            e.YtdSalary = pr.YtdSalary;
            e.YtdTax = pr.YtdTax;
            org.Hire(e);
            break;
        case nameof(Contractor):
            var c = new Contractor(pr.Name, pr.Id, pr.PayRate);
            c.HomeAddress = pr.HomeAddress;
            org.Hire(c);
            break;
        case nameof(Intern):
            var i = new Intern(pr.Name, pr.Id);
            i.HomeAddress = pr.HomeAddress;
            org.Hire(i);
            break;
    }
}
```

Finally, return the organization!

### Program.cs
Now, add some code to the top of Program.cs to restore the organization.

```csharp
var org = OrganizationSerializer.Deserialize($@"{projPath}\PayrollData.json")
    ?? new Organization("Acme Corporation", "12-1234567");
```

This will restore the organization if the file exists.  If the file does not exist, it will create a new organization.
