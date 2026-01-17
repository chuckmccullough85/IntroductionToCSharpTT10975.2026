
using Microsoft.VisualBasic;

var ftemps = new double[] { -40, 0, 20, 32, 65, 72, 100, 150, 212 };
foreach (var f in ftemps)
{
    var c = F2C(f);
    var k = F2K(f);
    Console.WriteLine($"{f}F is {c}C and {k}K");

    Console.WriteLine($"Convert back: {C2F(c)}f, {K2F(k)}f");
}


double F2C (double fahr)
{
    double C = 5.0f / 9.0f * (fahr - 32);
    return C;
}
double F2K (double fahr)
{
    return C2K(F2C(fahr));
}
double C2F (double cels)
{
    return cels * 9 / 5 + 32;
}
double C2K(double cels)
{
    return cels + 274.15;
}
double K2C(double k)
{
    return k - 274.15;
}
double K2F(double k)
{
    return C2F(K2C(k));
}


// ---------- Challenge --------------
var year0 = new DateTime(1, 1, 1);
var now = DateTime.Now;
var elapsed = now - year0;
Console.WriteLine($"the number of seconds that have elapsed since the year 0 is {elapsed.TotalSeconds}");
Console.WriteLine("The number of possible decks of cards is " + Factorial(52));
Console.WriteLine($"Factorial of 5 is {Factorial(5)}");

var primes = GetPrimes(100);
Console.WriteLine("First 100 prime numbers are:");
foreach (var prime in primes)
    Console.Write(prime + " ");

// ---------- Challenge --------------

// Factorial of a number is the product of all positive integers less than or 
//    equal to that number.
// Recursive function is a function that calls itself.
// Write a program to calculate the factorial of a number using a recursive function.

UInt128 Factorial(UInt128 n)
{ 
    // special case for 0
    if (n == 0) return 1;
    return n * Factorial(n - 1);
}

bool IsPrime(int candidate)
{
    // even numbers are not prime unless the number is 2
    if (candidate == 2) return true;

    // any odd number will have the least significant bit set to 1
    // if it is not set, anding the number with 1 will return 0
    // this is a quick way to check if the number is odd or even
    if ((candidate & 1) == 0) return false;

    // check odd numbers starting from 3
    // we only need to check up to the square root of the number
    for (int i = 3; (i * i) <= candidate; i += 2)
        if ((candidate % i) == 0)  // divisible by i
            return false;

    return candidate != 1;
}

// create an array containing the first n prime numbers
int[] GetPrimes(int n)
{
    var primes = new int[n];
    int found = 0;
    int i = 2;
    while (found < n)
    {
        if (IsPrime(i))
        {
            primes[found++] = i;
        }
        i++;
    }
    return primes;
}

