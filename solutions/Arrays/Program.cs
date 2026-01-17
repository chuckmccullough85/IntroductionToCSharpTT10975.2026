// dotnet add package SixLabors.ImageSharp
// using System.Numerics;
// using MathNet.Numerics;



Console.WriteLine("F\tC\t\tK");

float[] ftemps = { -40, 0, 20, 32, 55, 72, 90, 100, 110, 212 };

foreach (var F in ftemps)
{
    double C = 5.0f / 9.0f * (F - 32);
    double K = C + 274.15;
    if (F <= 20) Console.Write('*');
    else if (F > 130) Console.Write('^');
    Console.WriteLine($"{F}\t{C}\t{K}");
}



