
using Payroll;
using static MenuMaker.Prompt;
using static System.Console;

namespace PaywizUI;

public class EditEmployee(Employee model) : View<Employee>(model)
{
    public override void Display()
    {
        WriteLine("Edit Employee");
        WriteLine(Model);
        WriteLine("--------------------");
        Model.Id = GetInt("Enter ID: ", Model.Id);
        Model.Name = GetString("Enter name: ", Model.Name);
        Model.Salary = (float)GetDouble("Enter salary: ", Model.Salary, 50, 1000);
        Model.DateOfBirth = GetDate("Enter birth date: ", Model.DateOfBirth.ToShortDateString());
        if (Confirm("Enter HomeAddress?"))
            WriteLine("Enter HomeAddress");
    }

}