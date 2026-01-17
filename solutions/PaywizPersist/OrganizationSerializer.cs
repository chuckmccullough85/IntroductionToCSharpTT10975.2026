using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Location;
using Payroll;

namespace PaywizUI;

// define a record that is the union of HumanResource, Employee, Contractor, and Intern
// this is a technique similar to the TPH inheritance pattern in EF Core
[method: JsonConstructor]
record PayableRecord(
    int Id, string Classname, string Name, DateTime DateOfBirth, Address? HomeAddress, // HR
    float Salary, float YtdSalary, float YtdTax, Address? WorkAddress, // Employee
    float PayRate)
{
    public PayableRecord(Employee e) : this(
        e.Id, nameof(Employee), e.Name, e.DateOfBirth, e.HomeAddress,
        e.Salary, e.YtdSalary, e.YtdTax, e.WorkAddress, 0) { }
    public PayableRecord(Contractor c) : this(
        c.Id, nameof(Contractor), c.Name, c.DateOfBirth, c.HomeAddress,
        0, 0, 0, null, c.PayRate) { }
    public PayableRecord(Intern i) : this(
        i.Id, nameof(Intern), i.Name, i.DateOfBirth, i.HomeAddress,
        0, 0, 0, null, 0) { }
}

record OrganizationRecord (string Name, string Id, IEnumerable<PayableRecord> Payables);

public static class OrganizationSerializer
{
    public static void Serialize(Organization org, string path)
    {
        var payables = org.Employees
            .Where(e=>e is Employee)
            .Select(e => new PayableRecord((e as Employee)!))
            
            .Concat(org.Employees
            .Where(e=>e is Contractor)
            .Select(c => new PayableRecord((c as Contractor)!)))

            .Concat(org.Employees
            .Where(e=>e is Intern)
            .Select(i => new PayableRecord((i as Intern)!)));

        var orgRecord = new OrganizationRecord(org.Name, org.TaxId, payables);
        var json = JsonSerializer.Serialize(orgRecord, 
            new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }

    public static Organization? Deserialize(string path)
    {
        var json = File.ReadAllText(path);
        var orgRecord = JsonSerializer.Deserialize<OrganizationRecord>(json);
        if (orgRecord == null) return null;
        var org = new Organization(orgRecord.Name, orgRecord.Id);
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
        return org;
    }

}