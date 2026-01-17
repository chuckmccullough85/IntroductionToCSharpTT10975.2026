## Overview
Fun with method parameters!

| | |
| --------- | --------------------------- |
| Exercise Folder | Method Parameters |
| Builds On | None |
| Time to complete | 60 minutes
## Success Criteria
Your solution should:
- Implement methods with default parameters demonstrating parameter defaults
- Implement methods with variable length parameter lists (params keyword)
- Demonstrate method overloading with multiple signatures
- Implement methods using `out` parameters for return values
- Implement methods using `ref` parameters for reference modification
- Show correct usage of each parameter type in Main method

## Where to find the solution
See [solutions/MethodParameters](../../solutions/MethodParameters)
---

In this exercise, you will demonstrate:
* methods with default parameters
* methods with variable length parameter lists
* overloaded methods
* out parameters
* ref parameters

> **Note:** C# does not allow overloaeded methods in *top-level* code.  So, for this lab, we will use the traditional *Program* class with a *Main* method.  In any application, you can use the *refactoring* lightbulb to convert a class with *main* into top-level code and vice-versa.  The C# compiler simply generates a class with a *Main* method for you when you use top-level code.

---

### Steps
1. Create a new console application named *MethodParameters*
1. Replace the contents of *Program.cs* with the following code:
```csharp
class Program
{
    static void Main(string[] args)
    {
    }
}
```
3. Add 2 methods named *Display* to the class as shown below:
```csharp
static void Display(string message){}
```
and 
```csharp
static void Display(int number){}

4. In the body of each method, use `Console.WriteLine` to display the parameter value as well as text that identifies the method.  
5. In the *Main* method, call each of the *Display* methods with a string and an integer parameter.  Observe that the correct method is called based on the parameter type.
6. Add another method named `Greet` as shown bellow:
```csharp
static void Greet(string name = "User"){}
```
7. In the body of the method, use `Console.WriteLine` to display the parameter value as well as text that identifies the method.
8. In the *Main* method, call the *Greet* method with no parameters and with a parameter. 
9. Add another method named `Sum` as shown bellow:
```csharp
static void Sum(params int[] numbers){}
```
10. In the body of the method, loop through the array of numbers and add them together.  Display the sum.
11. In the *Main* method, call the *Sum* method with different numbers of parameters.


### ref & out parameters

Create a method that can resize an existing array of integers and provide some statistical data about the array.

`static float Resize(int newSize, ref int[] array, out int total)`
* The method will allocate a new array of *newSize* and copy the contents of the existing array into the new array.
* Then, overwrite the array parameter with the new array.
* Calculate the total of the numbers in the array and return it in the *total* parameter.
* Calculate the average of the numbers and return that as the method's return value.

#### Steps
1. Add the *Resize* method to the *Program* class.  Implement the method as described above.  
  * note - cast either the numerator or denominator to a float to get a floating point result when calculating the average.
  * ie *return **(float)** total / array.Length;*
2. In the *Main* method, create an array of integers and initialize it with some values.
3. Call the *Resize* method and pass the array as a *ref* parameter.
4. Display the total and average of the numbers in the array.
