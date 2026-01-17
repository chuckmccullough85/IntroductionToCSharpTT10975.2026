## Overview
In this lab, we generate a table of temperatures.

| | |
| --------- | --------------------------- |
| Exercise Folder | Conditionals |
| Builds On | For Loop |
| Time to complete | 10 minutes

- Certain temperatures are dangerous
- Notify the user by displaying a ^ to indicate that it is hot if the temperature is above 130F
- Display an * at the start of the line for temperatures below 20F

 --- 
 
 *If you need a hint - check it out:*
 ```C#
for (double F = -40; F <= 212; F += 2)
{
    double C = (F - 32.0) * 5.0/9.0;
    double K = C + 273.15;
    if (F <= 20) Console.Write('*');
    else if (F > 130) Console.Write('^');
    Console.WriteLine($"{F}\t{C}\t{K}");
}
 ```
 
### Success criteria
- Outputs a table with markers: `*` for ≤ 20°F and `^` for > 130°F.
- Uses accurate conversion formulas and a step of 2°F.

### Where to find the solution
For reference, see the completed example in:
- solutions/Conditionals/Conditionals.csproj

### Want More?
Watch this short video:

[https://youtu.be/KA7HA7b6a68](https://youtu.be/KA7HA7b6a68)