## Overview
Create a class to prompt the user for information.

| | |
| --------- | --------------------------- |
| Exercise Folder | Prompt |
| Builds On | MenuMaker |
| Time to complete | 20 minutes |\n\n## Success Criteria\nYour solution should:\n- Implement `GetString(string prompt, string? def, int maxLength = 50)` method\n- Implement `GetInt(string prompt, int def=0, int min = 0, int max = 100)` method\n- Implement `GetDouble(string prompt, double def=0, double min = 0, double max = 10_000)` method\n- Implement `GetDate(string prompt, string def=\"01/01/1980\")` method\n- Implement `Confirm(string prompt)` method for yes/no confirmation\n- Support default values for all methods\n- Validate input within specified ranges\n\n## Where to find the solution\nSee [solutions/Prompt](../../solutions/Prompt)\n\nContinue with the *MenuMaker* project

### Steps
1. Create a new static class called *Prompt*.
2. Using the course guide as a reference, add methods to prompt the user for different data types
        - `public static string GetString(string prompt, string? def, int maxLength = 50)`
        - `public static int GetInt(string prompt, int def=0, int min = 0, int max = 100)`
        - `public static double GetDouble(string prompt, double def=0, double min = 0, double max = 10_000`
        - `public static DateTime GetDate(string prompt, string def="01/01/1980")`
        - `public static bool Confirm(string prompt)`


Add the following code to one of the existing callback methods (like Beep()) so that you can test your prompter.

```csharp
void Beep(MenuItem _) // discard the MenuItem parameter since we don't need it
{
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
```
