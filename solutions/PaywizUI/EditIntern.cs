using Payroll;
using static MenuMaker.Prompt;
using static System.Console;
namespace PaywizUI;

class EditIntern (Intern model) : View<Intern>(model)
{
    public override void Display()
    {
        WriteLine("Edit Intern");
        WriteLine(Model);
        WriteLine("--------------------");
        Model.Id = GetInt("Enter ID: ", Model.Id);
        Model.Name = GetString("Enter name: ", Model.Name);
        Model.DateOfBirth = GetDate("Enter birth date: ", Model.DateOfBirth.ToShortDateString());
    }
}