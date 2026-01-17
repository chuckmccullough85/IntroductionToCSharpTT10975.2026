using MenuMaker;
using Payroll;
using static System.Console;
using static MenuMaker.Prompt;

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
            ("Edit Employee/Contractor/Intern", EditEmployee),
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
        var i = new Intern("John Doe", 1);
        new EditIntern(i).Display();
        Model.Hire(i);
    }

    private void EditEmployee(MenuItem _)
    {
        var name = GetString("Enter Employee Name: ", null);
        var payable = Model.Employees.Find(e => e.Name.ToUpper().Contains(name.ToUpper()));
        if (payable == null) return;
        if (payable is Employee e) new EditEmployee(e).Display();
        else if (payable is Contractor c) new EditContractor(c).Display();
        else if (payable is Intern i) new EditIntern(i).Display();
    }

    public override void Display()
    {
        _menu.Run();
    }

    private void TerminateEmployee(MenuItem _)
    {
        var name = GetString("Enter Employee Name: ", null);
        var payable = Model.Employees.Find(e => e.Name.ToUpper().Contains(name.ToUpper()));
        if (payable == null) return;
        if (Confirm($"Are you sure you want to terminate {payable.GetType().Name} {payable.Name}?"))
            Model.Terminate(payable);
    }

}
