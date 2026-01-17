using MenuMaker;
using Payroll;
using static System.Console;

namespace PaywizUI;


public class HireTerminateMenu : View<Organization>
{
    private Menu _menu;

    public HireTerminateMenu(Organization model) : base(model)
    {
        _menu = new Menu("PayWiz - Hire/Terminate",
            ("Hire Employee", HireEmployee),
            ("Hire Contractor", HireContractor),
            ("Hire Intern", HireIntern),
            ("Terminate Employee", TerminateEmployee));
    }

    private void HireEmployee(MenuItem _)
    {
        var e = new Employee("John Doe", 1, 50, new DateTime(1990, 1, 1));
        new EditEmployee(e).Display();
        Model.Hire(e);
    }

    private void HireContractor(MenuItem _)
    {
        var c = new Contractor("John Doe", 1, 50);
        new EditContractor(c).Display();
        Model.Hire(c);
    }

    private void HireIntern(MenuItem _)
    {
        var i = new Intern ("John Doe", 1);
        new EditIntern(i).Display();
        Model.Hire(i);
    }

    public override void Display()
    {
        _menu.Run();
    }    
    
    private void TerminateEmployee(MenuItem _) => WriteLine("Terminate Employee");

}