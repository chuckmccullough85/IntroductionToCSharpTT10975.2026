
bool done = false;

while (!done)
{
    Console.Write("Enter a fahrenheit temperature: ");
    var text = Console.ReadLine()!;
    if (text.Length != 0)
    {
        var F = double.Parse(text.Trim());
        double C = 5.0f / 9.0f * (F - 32);
        double K = C + 274.15;
        if (F <= 20) Console.Write('*');
        else if (F > 130) Console.Write('^');
        Console.WriteLine($"{F}F\t{C}C\t{K}K");
    }
    else done = true;
}