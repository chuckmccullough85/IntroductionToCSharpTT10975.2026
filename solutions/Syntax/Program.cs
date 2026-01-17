// Symbox syntax
// A symbol consists of any number of letters, digits, or underscores, 
// but must start with a letter or underscore.
// Also, case-sensitive.
int myvariable;
// is different from
int MyVariable;
//int 9lives; // invalid

myvariable = MyVariable = 5;
Console.WriteLine ($"{myvariable} ${MyVariable}");
// declaring (or defining) a variable is
// type name;
int myInt;
// cannot have duplicate declarations
//int myInt; <-- invalid, already declared

// assignment vs initialization

// assignment - giving a variable a value after it is declared
myInt = 5;
// initialization - giving a variable a value when it is declared
int myInt2 = 5;
Console.WriteLine($"{myInt} {myInt2}");
// type strictness
// once a variable is declared with a type, it cannot be changed
//myInt = "hello"; // invalid - myInt is an int, not a string

// variables can be reassigned
myInt = 10; // previously 5

// literal values
// a literal value is a value that is written directly in the code
// 5 is a literal value
// "hello" is a literal value

// notation for literal types
// 5 is an int
// 5.0 is a double
// 5f is a float
// 5L is a long
// 5u is a uint
// 5m is a decimal

int wholeNum = -20;
long bigNum = 22_678_123; // underscores are ignored, used for readability
uint positive = 223;
var pif = 3.14f;
double pid = 3.141567896;
//decimal money = 0;

// char is a single character - literals are in single quotes
char c = 'c';
// string is a sequence of characters - literals are in double quotes
string text = "This is a string";

Console.WriteLine($@"I wrote a program in C# and here is some data:
wholeNum: {wholeNum},
bigNum: {bigNum},
positive: {positive},
pif: {pif},
pid: {pid},
c: {c},
and text: {text}.
Have a nice day!");

Console.WriteLine($"""
   Oh, and here is the same thing, but with a raw string:
   wholeNum: {wholeNum},
   bigNum: {bigNum},
   positive: {positive},
   pif: {pif},
   pid: {pid},
   c: {c},
   and text: {text}.
   Have a nice day!
   """);

// Console is a class in the System namespace
// WriteLine is a method in the Console class
// WriteLine writes a line of text to the console
// $ is an interpolated string
// {} is a placeholder for a variable
// \n is a newline character
// \t is a tab character
// if the parameter is not a string, it is converted to a string
Console.WriteLine($"Hello, World! {wholeNum} (extra newline)\n");

Console.WriteLine(5 / 9); Console.WriteLine(9 / 5);
string s = 22.ToString(); // "22"
double x = double.Parse("3.14");

short sh = 15;
int i = sh; // implicit conversion
//short sh2 = (short)j; // explicit conversion