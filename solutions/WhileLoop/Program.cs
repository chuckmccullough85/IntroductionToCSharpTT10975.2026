// ouput F tab C tab K
Console.WriteLine("F\tC\t\tK");
// start at -40F
double F = -40;
while (F <= 212) // stop at 212F
{
    double C = 5.0f / 9.0f * (F - 32);
    double K = C + 274.15;
    // output value of F tab value of C tab ...
    Console.WriteLine($"{F}\t{C}\t{K}");
    F++;
}