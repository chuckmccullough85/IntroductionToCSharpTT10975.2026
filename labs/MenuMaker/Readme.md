## Overview
Let's make a menu! *MenuMaker*!

| | |
| --------- | --------------------------- |
| Exercise Folder | MenuMaker |
| Builds On | None |
| Time to complete | 40 minutes
## Success Criteria
Your solution should:
- Create `MenuItem` record with Text and Command properties
- Implement `Menu` class that displays numbered menu items
- Support params-based constructor for flexible menu item addition
- Implement Display() method showing title and numbered options
- Implement Run() method for user interaction and command dispatch
- Handle invalid input gracefully
- Support extensibility for other projects to use

## Where to find the solution
See [solutions/MenuMaker](../../solutions/MenuMaker)
## Setup
1. Create a new *Console* project in named *MenuMaker*.
2. Create a class named *Menu*.
    - In Visual Studio, right-click on the project and select *Add* -> *Class*. Name the class *Menu*.
        - delete the contents of the provided file
    - In VS Code, create a new file named *Menu.cs* in the project folder.
3. At the top, define a file scoped namespace named *MenuMaker*.
4. Next, define a `record` named *MenuItem* with two properties: *Text* and *Command*.
    - *Text* should be a string.
    - *Command* should be an `Action` `delegate` that takes *MenuItem* as a parameter.

--- 

#### Menu
1. After *MenuItem*, define a public class named *Menu*
2. Define a private field `List<MenuItem>` named *_items*.
    - initialize it to a new list of *MenuItem*.

3. Define a constructor that accepts the *title* as the first argument and a **params** argument accepting tuples of `(string, Action<MenuItem>)`.
    - In the constructor, set the *Title* property to the provided *title*.
    - For each tuple in the **params** argument, add a new *MenuItem* to the *_items* list with the *Text* and *Command* properties set to the tuple's values.

4. Define an auto property *Title* of type string.
5. Define a method `Display()` that 
    - clears the console - `Console.Clear()`
    - writes the *Title* to the console and then writes each *MenuItem* in the *_items* list to the console.
    - Each *MenuItem* should be displayed with a number and the *Text* property.
    - The number should be the index of the *MenuItem* in the list plus one.
    - always add a "Quit" option at the end of the menu.

6. Define a method `Run()` that
    - has an infinte loop `while(true)`
    - calls `Display()` to show the menu
    - reads a line from the console and parses it to an integer
    - if the integer is less than or equal to the count of items, call the *Command* of the selected *MenuItem*.
    - if the integer is greater than the count of items, repeat.
    - if the integer is 0, break the loop. (quit)

---

#### Program
Here's some test code to test your *Menu* class.  Put this in your *Program.cs* file and run it.

```csharp
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
```