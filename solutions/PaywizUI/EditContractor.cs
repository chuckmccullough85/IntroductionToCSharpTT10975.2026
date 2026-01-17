using Payroll;
using static MenuMaker.Prompt;
using static System.Console;
namespace PaywizUI;

class EditContractor (Contractor model) : View<Contractor>(model)
{
    public override void Display()
    {
        WriteLine("Edit Contractor");
        WriteLine(Model);
        WriteLine("--------------------");
        Model.Id = GetInt("Enter ID: ", Model.Id);
        Model.Name = GetString("Enter name: ", Model.Name);
        Model.PayRate = (float)GetDouble("Enter hourly rate: ", Model.PayRate, 50, 100);
        Model.DateOfBirth = GetDate("Enter birth date: ", Model.DateOfBirth.ToShortDateString());
    }
}