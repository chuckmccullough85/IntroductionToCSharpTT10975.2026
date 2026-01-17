
for (double F = -40; F <= 212; F+=2) 
{
    double C = 5.0f / 9.0f * (F - 32);
    double K = C + 274.15;
    Console.WriteLine($"{F}\t{C}\t{K}");
}