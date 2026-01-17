using MenuMaker;

var menu = new Menu("Payroll Wizard", 
    ("Travel", SayGoodbye),
    ("Stay Home", SayHello), 
    ("Make Noise!", Beep));

menu.Run();

void SayHello(MenuItem item) => Console.WriteLine("Hello, World!");
void SayGoodbye(MenuItem item) => Console.WriteLine("Goodbye, World!");
void Beep(MenuItem _) // discard the MenuItem parameter since we don't need it
{
    Console.Beep();
}