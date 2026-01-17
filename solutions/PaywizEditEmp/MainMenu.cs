
namespace PaywizUI;
using MenuMaker;
using Payroll;
using static MenuMaker.Prompt;
using static System.Console;

public class MainMenu : View<Organization> 
{
    private Menu _menu;

    public MainMenu(Organization model) : base(model)
    {
        _menu = new Menu("Payroll Wizard: Main Menu",
            ("Hire/Terminate", HireTerminate),
            ("Run Payroll", RunPayroll),
            ("List Employees", ListEmployees));
    }   

    private void HireTerminate(MenuItem _) => new HireTerminateMenu(Model).Display();
    private void RunPayroll(MenuItem _)
    {
        var net = Model.Pay();
        WriteLine($"Payroll run. Net payroll: {net:C}");
        Confirm("Press any key to continue...");
    }

    private void ListEmployees(MenuItem _)
    {
        
        WriteLine("List Employees");
        WriteLine("--------------");
        foreach (var e in Model.Employees)
            WriteLine(e);
        
        Confirm("Press any key to continue...");
    }

    public override void Display()
    {
        _menu.Run();
    }
}