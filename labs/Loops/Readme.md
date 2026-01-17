## Overview
What can we do with loops? 

| | |
| --------- | --------------------------- |
| Exercise Folder | Loops |
| Builds On | None |
| Time to complete | 20 minutes |\n\n## Success Criteria\nYour solution should:\n- Implement Fibonacci series generation using loops\n- Demonstrate for loops with different patterns\n- Show correct mathematical calculations\n- Display results in clear, readable format\n\n## Where to find the solution\nSee [solutions/Loops](../../solutions/Loops)\n\n---\n\n- Create a new console project.  In *Program.cs*, try these loops:

### Fibonacci Series
We can use a loop to calculate Fibonacci numbers.

```csharp
// Create a for loop to produce fibonacci series
// The first two numbers in the Fibonacci sequence are 0 and 1, 
// and each subsequent number is the sum of the previous two.
int n = 10;
int a = 0;
int b = 1;
int c = 0;
Console.WriteLine("Fibonacci series:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    c = a + b;
    a = b;
    b = c;
}
```

### Calculate Pi
We can use a loop to calculate Pi using the Leibniz formula.

```csharp
// Calculate PI using the Leibniz formula
// PI = 4/1 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 + ...
int max = 1000000;
double pi = 0;
for (int i = 0; i < max; i++)
{
    pi += 4.0 / (2 * i + 1) * (i % 2 == 0 ? 1 : -1);
}
Console.WriteLine($"PI is approximately {pi}");
```

### Prime Numbers
We can use a nested loop to find prime numbers.

```csharp
// Find the first 20 prime numbers
// A prime number is a number that is greater than 1 and is only 
// divisible by 1 and itself.
// The first prime number is 2.
// We find prime numbers by checking if a number is divisible by any
// number less than its square root.
Console.WriteLine("First 100 prime numbers:");
int count = 0;
int num = 2;
while (count < 100)  // loop until we find 100 prime numbers
{
    bool isPrime = true;
    // num is the candidate prime number
    // go from 2 to the square root of num 
    // if num is divisible by any number, it is not prime
    // stop checking when we find a divisor
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(num);
        count++;
    }
    num++;  // check the next number
}
```