## Overview
In this lab, we create temperature conversion methods.

| | |
| --------- | --------------------------- |
| Exercise Folder | BasicMethods |
| Builds On | None |
| Time to complete | 45-60 minutes |

## Success Criteria
Your solution should:
- Implement all conversion methods: F2C, F2K, C2F, C2K with correct formulas
- Implement K2C and K2F as challenges
- Call each method with test values to verify accuracy
- Display results with clear labels and proper formatting
- Verify formulas produce correct conversions (e.g., 32°F = 0°C)

## Where to find the solution
See [solutions/BasicMethods](../../solutions/BasicMethods)

---
## Instructions
1. Add a new console application to your solution - named *BasicMethods*
1. In *Program.cs* add the following method skeletons to the bottom of the file
```C#
double F2C (double f)
{
    return 0;
}
double F2K (double f)
{ 
    return 0; 
}
double C2F (double c)
{
    return 0;
}
double C2K (double c)
{
    return 0;
} 
```
- F2C returns the Celsius temp from a fahrenheit temp
- F2K returns the Kelvin temp from a farenheit temp
- you get the idea...
3. Reference the formulas you created in earlier exercises, complete the methods
3. Add code *above* these methods to call with various sample data and print the converted temps
	- in *top level code files* methods must be below all top level code
5. *Challenge* - use a loop to convert ranges of temperatures using the methods

---

### Extra Credit

Methods are used in real-world applications to perform a singular task and thus remove the need to duplicate code.  In these challenges, we will create some methods that perform some useful tasks.

### Recursion
A method that calls itself is called a recursive method.  Create a recursive method that calculates the factorial of a number.  The factorial of a number is the product of all positive integers less than or equal to the number.  For example, the factorial of 5 is 5 * 4 * 3 * 2 * 1 = 120.  The factorial of 0 is 1.  The factorial of a negative number is undefined.

##### Steps
1. Add a new method to the bottom of *Program.cs* named *Factorial*
1. The method should take an unsigned long integer parameter and return unsigned long
1. if the parameter is 0, return 1
1. otherwise, return the parameter times the result of calling *Factorial* with the parameter minus 1

Above the method in your top-level code, call the *Factorial* method with various values and print the results.
The number of unique decks of cards is 52 factorial.  This is an incredibly large number.  Try calculating the factorial of 52 and see what happens.  Compare the result to the number of atoms in the universe (google it).

---

### Prime Numbers

A prime number is a number that is only divisible by 1 and itself.  Write a method that determines if a number is prime.  The method should take an integer parameter and return a boolean.  The method should return true if the number is prime and false if it is not.

##### Steps

1. Add a new method to the bottom of *Program.cs* named *IsPrime*
1. The method should take an integer parameter and return a boolean
1. If the parameter is less than 2, return false
1. Loop from 2 to the square root of the parameter
    1. If the parameter is divisible by the loop variable, return false (hint: use the modulo operator)
1. Return true

Add some code to the top of the file that calls the *IsPrime* method with various values and prints the results.  Verify that it is accurate by checking the results against a list of prime and non-prime numbers.

#### Find Prime numbers
Next, create a method that returns an array of prime numbers.  We will pass in how many we want.

##### Steps
1. Add a new method to the bottom of *Program.cs* named *GetPrimes*
1. The method should take an integer parameter and return an array of integers
1. Inside the method, declare an array of integers to hold the prime numbers - size the array to the parameter
1. Create a variable to hold the number of primes found and set it to 0
1. Loop from 2 to the maximum integer value
    1. If the number is prime, add it to the array and increment the number of primes found
    1. If the number of primes found is equal to the parameter, break out of the loop
1. Return the array

Add some code to the top of the file that calls the *GetPrimes* method with various values and prints the results.  Verify that it is accurate by checking the results against a list of prime numbers.

### Success criteria
- Methods return correct values using accurate formulas:
    - `double F2C(double f) => (f - 32.0) * 5.0/9.0;`
    - `double F2K(double f) => ((f - 32.0) * 5.0/9.0) + 273.15;`
    - `double C2F(double c) => (c * 9.0/5.0) + 32.0;`
    - `double C2K(double c) => c + 273.15;`
- Example calls print clear, labeled results.

### Where to find the solution
For reference, see the completed example in:
- solutions/BasicMethods/BasicMethods.csproj