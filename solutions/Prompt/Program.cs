using MenuMaker;
using static MenuMaker.Prompt;
using static System.Console;


var menu = new Menu("Payroll Wizard",
    ("Travel", SayGoodbye),
    ("Stay Home", SayHello),
    ("Make Noise!", Beep));

menu.Run();

void SayHello(MenuItem item) => WriteLine("Hello, World!");
void SayGoodbye(MenuItem item) => WriteLine("Goodbye, World!");
void Beep(MenuItem _) // discard the MenuItem parameter since we don't need it
{
    Console.Beep();
    var s = GetString("Enter your name: ", "Joe");
    WriteLine($"Hello, {s}!");
    var a = GetInt("Enter your age: ", 22);
    WriteLine($"You are {a} years old.");
    var d = GetDouble("Enter a real number: ");
    WriteLine($"You entered {d}.");
    var bd = GetDate("Enter your birthdate: ");
    WriteLine($"You were born on a {bd.DayOfWeek}.");

    if (Confirm("Are you sure you want to continue?"))
        WriteLine("Continuing...");
    else
        WriteLine("Exiting...");

}