## Overview
Continue implementing paywiz by enabling editing of employees, contractors, and interns.

| | |
| --------- | --------------------------- |
| Exercise Folder | PaywizEditEmp |
| Builds On | PaywizUI |
| Time to complete | 60 minutes

## Success Criteria
Your solution should:
- Add `string Name` property to Payable interface (with default "NA")
- Implement case-insensitive name search with Contains method
- Use `is` keyword to determine runtime type and dispatch to correct Edit class
- Support editing Employee, Contractor, and Intern types through unified interface
- Implement Terminate functionality with confirmation prompt
- Handle null/not-found cases gracefully
- Copy Payroll classes locally to avoid modifying previous projects

## Where to find the solution
See [solutions/PaywizEditEmp](../../solutions/PaywizEditEmp)

---

> Note: During this lab, modifications will be made to the *Payroll* classes (reference to a previous lab).  To avoid making these changes to code in a previous lab, the *Payroll* classes will be copied to the *PaywizEditEmp* project.  This will allow the *Interfaces* project to remain unchanged.

> Note - we will use the term *employee* to generically refer to employees, contractors, and interns.

Our requirement is that the end user will select an existing employee, contractor, or intern from a list of employees and then edit the selected employee's information.  The user will first enter the name of the employee they wish to edit.

**Problem:** The employee list in *Organization* is a list of *Payable* types.  While the real, underlying object is probably an *Employee*, *Contractor*, or *Intern*, the list is of type *Payable*.  This means that we can't directly access the properties of the underlying object.  In order to search the list by name, we need to be able to access the name property of the underlying object.

**Solution:** We will add a property to the *Payable* interface that will return the name of the employee.  This will allow us to search the list of employees by name.  Since there might be some classes other than *HumanResource* that implement *Payable* that don't have a name property, we will provide a default implementation for the property.

## Instructions
1. Add the following to the *Payable* interface:
```csharp
string Name => "NA";
```

2. Add a menu option to *HireTerminateMenu* '("Edit Employee/Contractor/Intern", EditEmployee),` that will call the *EditEmployee* method.

```csharp
public HireTerminateMenu(Organization model) : base(model)
{
    _menu = new Menu("PayWiz - Hire/Terminate",
        ("Hire Employee", HireEmployee),
        ("Hire Contractor", HireContractor),
        ("Hire Intern", HireIntern),
        ("Edit Employee/Contractor/Intern", EditEmployee),
        ("Terminate Employee", TerminateEmployee));
}
```

3. Now, implement the *EditEmployee* method.  This method will prompt the user for the name of the employee they wish to edit.  If the employee is found, the user will be prompted to enter the new information for the employee.  

In this example:
- Using the `Find` which will return the first item that matches the condition.
- In our `Find` predicate, we are using the `ToUpper` method to make the search case-insensitive and looking for a partial match of the name by using `Contains`.  Would it be possible to present a list of matches and have the user select the correct one?
- The `is` keyword is used to determine the type of the object and create a variable of the appropriate type.  
- The EditEmployee, EditContractor, and EditIntern classes are used to prompt the user for the new information for the employee.  These are the same classes used to hire the employee, contractor, and intern.

```csharp
private void EditEmployee(MenuItem _)
{
    var name = GetString("Enter Employee Name: ", null);
    var payable = Model.Employees.Find(e => e.Name.ToUpper().Contains(name.ToUpper()));
    if (payable == null) return;
    if (payable is Employee e) new EditEmployee(e).Display();
    else if (payable is Contractor c) new EditContractor(c).Display();
    else if (payable is Intern i) new EditIntern(i).Display();
}
```


--- 

### Terminating an Employee

We can reuse some of this code to implement *Terminate*.  The *Terminate* method will prompt the user for the name of the employee they wish to terminate.  If the employee is found, the employee will be removed from the list of employees after confirming that the user wants to terminate the employee.

```csharp
private void TerminateEmployee(MenuItem _)
{
    var name = GetString("Enter Employee Name: ", null);
    var payable = Model.Employees.Find(e => e.Name.ToUpper().Contains(name.ToUpper()));
    if (payable == null) return;
    if (Confirm($"Are you sure you want to terminate {payable.GetType().Name} {payable.Name}?"))
        Model.Terminate(payable);
}
```