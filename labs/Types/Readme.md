## Overview

Understanding primitive data types.

| | |
| --- | ----- |
| Exercise Folder | Types |
| Builds On | None |
| Time to complete | 30 minutes |

## Success Criteria
Your solution should:
- Declare variables of multiple primitive types: byte, int, uint, long, float, double, char, bool
- Initialize each with appropriate literal values
- Display all values using Console.WriteLine
- Demonstrate understanding of range and precision for each type

## Where to find the solution
See [solutions/Types](../../solutions/Types)

---
1. Create a new console application named `Types`.
2. Open the `Program.cs` file.
3. Using the sample code below, create lines of code that help you understand the different primitive data types in C#.

```csharp
// The most basic data type is a byte. It is an 8-bit unsigned integer. 
// It can store values from 0 to 255.

byte a = 199;

// display the value of a in decimal, octal, hexadecimal and binary format
Console.WriteLine(a); // 255
Console.WriteLine(Convert.ToString(a, 8)); // 377
Console.WriteLine(Convert.ToString(a, 16)); // ff
Console.WriteLine(Convert.ToString(a, 2)); // 11111111

Console.WriteLine("-------------------");

// A signed byte uses the same amount of memory as an unsigned byte.
// The only difference is that it can store values from -128 to 127.
sbyte b = -20;
Console.WriteLine(Convert.ToString(b, 2)); // -1
Console.WriteLine("Notice the top bit is 1, which indicates a negative number");    

Console.WriteLine("-------------------");
// integers are whole numbers that can be positive, negative, or zero.
int c = 100;
// display the value of c in decimal, octal, hexadecimal and binary format
Console.WriteLine("int c = 100;");
Console.WriteLine(c); // 100
Console.WriteLine(Convert.ToString(c, 8)); // 144
Console.WriteLine(Convert.ToString(c, 16)); // 64
Console.WriteLine(Convert.ToString(c, 2)); // 1100100

// write to the console the maximum and minimum values of short, int, long
Console.WriteLine("-------------------");
Console.WriteLine("short: {0} to {1}", short.MinValue, short.MaxValue);
Console.WriteLine("int: {0} to {1}", int.MinValue, int.MaxValue);
Console.WriteLine("uint: {0} to {1}", uint.MinValue, uint.MaxValue);
Console.WriteLine("long: {0} to {1}", long.MinValue, long.MaxValue);

// floating point numbers are numbers that have a fractional part.
// float is a 32-bit floating point number.
Console.WriteLine("-------------------");
float d = 3.14f;
Console.WriteLine(d);

// double is a 64-bit floating point number.
Console.WriteLine("-------------------");
double e = 3.14;
Console.WriteLine(e);

// decimal is a 128-bit floating point number.
Console.WriteLine("-------------------");
decimal f = 3.14m;
Console.WriteLine(f);

// show the min and max values of float, double, decimal
Console.WriteLine("-------------------");
Console.WriteLine("float: {0} to {1}", float.MinValue, float.MaxValue);
Console.WriteLine("double: {0} to {1}", double.MinValue, double.MaxValue);
Console.WriteLine("decimal: {0} to {1}", decimal.MinValue, decimal.MaxValue);

// char is a 16-bit Unicode character.
Console.WriteLine("-------------------");
char g = 'A';
Console.WriteLine(g);

// show g as integer
Console.WriteLine((int)g);
// show g as binary
Console.WriteLine(Convert.ToString(g, 2));

// string is a sequence of characters.
Console.WriteLine("-------------------");
string h = "Hello, World!";
Console.WriteLine(h);
```