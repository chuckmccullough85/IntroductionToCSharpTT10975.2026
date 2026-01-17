
## Overview
Experimenting with value and reference types helps with understanding them.

| | |
| --------- | --------------------------- |
| Exercise Folder | References |
| Builds On | None |
| Time to complete | 20 minutes 

---
## Instructions
1. Create a new console application in your current solution
1. Paste the code below over *Program.cs*
1. Make the project the startup project
1. Run the application
1. Explain why modifications to a & b don't impact the other, but changes to either ```vals``` or ```copy``` changes both.

---

### nullable types
The `Console.ReadLine()` in this and the previous lab may warn of a nullable type problem.
What can be done to avoid the warning?

Hints:
- Use `string text = Console.ReadLine() ?? string.Empty;`
- Use `string?` for variables that may be null.

#### Starter code

```C#
int a = 5;
int b = a;

b++;

Console.WriteLine($"a is {a} and b is {b}");

float[] vals = { 1.618f, 3.14f, 8.15f };
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
string text = Console.ReadLine();
Console.WriteLine("You entered: " + text);
```

### Want More?
[youtube.com](https://youtu.be/5wCLsoLfEiw)

### Success criteria
- Clearly articulates the difference between value types (e.g., `int`) and reference types (e.g., arrays).
- Demonstrates that assigning an array to another variable copies the reference (not the contents).

### Where to find the solution
For reference, see the completed example in:
- solutions/References/References.csproj


