
for (double F = -40; F <= 212; F+=2)
{
    double C = 5.0f / 9.0f * (F - 32);
    double K = C + 274.15;
    if (F <= 20) Console.Write('*');
    else if (F > 130) Console.Write('^');
    Console.WriteLine($"{F}\t{C}\t{K}");
}