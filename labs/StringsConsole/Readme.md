## Overview
Get temperatures from the user

| | |
| --------- | --------------------------- |
| Exercise Folder | StringsConsole |
| Builds On | Arrays |
| Time to complete | 30 minutes 

Prompt the user for a temperature then display converted values.

### Steps
1. Define a ```bool done``` variable, initially set to false
1. Modify the loop to a ```while(!done)```
1. Inside the loop, prompt the user to enter a temperature
1. If the user enters non-blank
    1. Convert the string temperature to a number with `double.TryParse(text, out var f)` (handle invalid input)
    1. Display the C and K values 
1. Else if the user doesn't enter anything, set done to ```true```

> Note: You may see *nullable reference* warnings for input. Prefer `Console.ReadLine() ?? string.Empty` and use `double.TryParse` to avoid exceptions.

---



### Want More?
[youtube.com](https://youtu.be/XJnC8bg9nBY)

### Success criteria
- Handles blank and invalid input gracefully (no exceptions).
- Repeats until the user presses Enter on a blank line.
- Displays accurate conversions using:
    - `double C = (f - 32.0) * 5.0/9.0;`
    - `double K = C + 273.15;`

### Where to find the solution
For reference, see the completed example in:
- solutions/StringsConsole/StringsConsole.csproj
