int a = 5;
int b = a;

b++;

Console.WriteLine($"a is {a} and b is {b}");

float[] vals = [1.618f, 3.14f, 8.15f];
float[] copy = vals;

Console.WriteLine("Content of vals array: ");
foreach (var v in vals) Console.WriteLine(v);
Console.WriteLine("Content of copy: ");
foreach (var v in copy) Console.WriteLine(v);

copy[2] = 5.1999f;
Console.WriteLine("-----------");
Console.WriteLine("Content of vals array: ");
foreach (var v in vals) Console.WriteLine(v);
Console.WriteLine("Content of copy: ");
foreach (var v in copy) Console.WriteLine(v);

// correct the warning on the following line
string? text = Console.ReadLine();
Console.WriteLine("You entered: " + text);