## Overview
Create the UI for the Paywiz application.

| | |
| --------- | --------------------------- |
| Exercise Folder | PaywizUI |
| Builds On | Prompt |
| Time to complete | 60 minutes |

## Success Criteria
Your solution should:
- Create abstract `View<M>` base class with Model property and Display method
- Implement `MainMenu` displaying options for Hire/Terminate, Run Payroll, List Employees
- Implement `HireTerminateMenu` with submenu options for Employee, Contractor, Intern hiring
- Implement `EditEmployee` view for capturing employee information
- Add reference to Delegates project for access to Payable types
- Display employees in formatted list with proper console output
- Show payroll results with net pay in currency format

## Where to find the solution
See [solutions/PaywizUI](../../solutions/PaywizUI)

---

Now we have some fundamental building blocks - the user can make a choice and we can prompt the user for basic input.  We can now build a simple UI for the Paywiz application.

UI design patterns and practices dictates that we create a different class for each UI component.  The component can be primitive, like our menu or prompt, or more complex, like a form to edit employee information.  Each component will reference a single object for its data.  This is referred to as the model.  The code in the class that creates the presentation is the view, and the code that responds to the user's input is the controller.

In this exercise, we will create a simple UI for Paywiz.  We won't fully implement the application, but we will do enough that you get the general idea.  Also, not many applications nowadays are written in the console, but the principles are the same for a web application or a desktop application.

Before we get started, our application needs to use the *Employee, Contractor, Organization, etc.* classes that we created earlier.  You could just copy and paste the files from one project to another, but then you would have multiple places to update if a change is needed.  Instead, we will *reference* the other project from our UI project. 

## Visual Studio
- Right-click on the PaywizUI project and select *Add* -> *Project Reference...* and choose the *Delegates* project.

## VS Code
- Open a terminal in the same folder has the PaywizUI project and type
`dotnet add reference ../Delegates/Delegates.csproj `

### View
- Create a new abstract class `View<M>`
- Add a property `Model` of type `M`
- Add an abstract method `Display`

### MainMenu
- Create a new class `MainMenu` that inherits from `View<Organization>`
- Add a single field of type `MenuMaker`
- Add a constructor that takes an `Organization` and passes it to the base class constructor
- In the constructor, create a new `MenuMaker` and assign it to the field
    - Give the menu a title of "Main Menu"
    - Add a menu items for 
          - Hire/Terminate
          - Run Payroll
          - List Employees
    - You will need to create methods in the class to handle the menu items.  For now, just write a message to the console that the menu item was selected.

### Program.cs
- Create an organization object
- Create a new instance of `MainMenu` and call the `Display` method

```csharp
var org = new Organization("Acme Corporation", "12-1234567");
new MainMenu(org).Display();
```

Run your application to make sure the main menu is displayed.  Next, we will work on the Hire/Terminate menu item.

### HireTerminateMenu
- Create a new class `HireTerminateMenu` that inherits from `View<Organization>`
- Add a single field of type `MenuMaker`
- Add a constructor that takes an `Organization` and passes it to the base class constructor
- In the constructor, create a menu with these menu items:
    - Hire Employee
    - Hire Contractor
    - Hire Intern
    - Terminate Employee
- Define handlers for each item that will write a message to the console

### MainMenu
Now, go back to `MainMenu` and change the handler for the Hire/Terminate menu item to create a new instance of `HireTerminateMenu` and call the `Display` method.

```csharp
private void HireTerminate(MenuItem _) => new HireTerminateMenu(Model).Display();
```

Change the handler for *List Employees* to loop through the *Organization* Employees and write the object to the console

```csharp
    private void ListEmployees(MenuItem _)
    {
        
        WriteLine("List Employees");
        WriteLine("--------------");
        foreach (var e in Model.Employees)
            WriteLine(e);
        
        Confirm("Press any key to continue...");
    }
```

Finally, update the *Run Payroll* handler to call the organization's `Pay()' method.  Display the net paid.

```csharp
private void RunPayroll(MenuItem _)
{
    var net = Model.Pay();
    WriteLine($"Payroll run. Net payroll: {net:C}");
    Confirm("Press any key to continue...");
}
```

Run your application to verify that you can navigate the menus that we have enabled.

### EditEmployee
We need a view that can be used to create and edit employees.

- Create a new class `EditEmployee` that inherits from `View<Employee>`
- Add a constructor that takes an `Employee` and passes it to the base class constructor
- Add a method `Display` that will prompt the user for the employee's
    - Name
    - ID
    - Salary
    - Date of birth

Use the `Prompt` class methods to help with the input.  Use the existing employee data as the default value for the prompt.

### HireTerminateMenu
Update the handler for *Hire Employee* to create a default *Employee* and a new instance of `EditEmployee` and call the `Display` method.

After `Display` returns, add the new employee to the organization.

```csharp
private void HireEmployee(MenuItem _)
{
    var e = new Employee("John Doe", 1, 50, new DateTime(1990, 1, 1));
    new EditEmployee(e).Display();
    Model.Hire(e);
}
```

You can now hire employees, pay them, and list them. 


### Optional, time permitting

Do the same for *Hire Contractor* and *Hire Intern*.