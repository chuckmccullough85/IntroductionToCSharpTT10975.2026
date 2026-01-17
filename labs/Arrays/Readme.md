| | |
| --------- | --------------------------- |
| Exercise Folder | Arrays |
| Builds On | Conditionals |
| Time to complete | 20 minutes |

## Success Criteria
Your solution should:
- Use foreach loop to iterate through temperature array
- Apply correct conversion formulas: C = (F - 32.0) * 5.0/9.0; K = C + 273.15
- Display all converted temperatures in clear table format
- Include conditional markers for extremes (* for ≤20°F, ^ for >130°F)

## Where to find the solution
See [solutions/Arrays](../../solutions/Arrays)

---

## Overview

- Building on the previous lab, define an array of temperatures as shown:

```csharp
double[] ftemps = { -40, 0, 20, 32, 55, 72, 90, 100, 110, 212 };
```

- Use a `foreach` loop to convert the temps in the array from F→C and F→K.
- Use accurate formulas:
	- `double C = (F - 32.0) * 5.0/9.0;`
	- `double K = C + 273.15;`

### Success criteria
- Display each original Fahrenheit temp with its Celsius and Kelvin conversions.
- Output formatting is clear (e.g., columns or tabs).

### Where to find the solution
For reference, see the completed example in:
- solutions/Arrays/Arrays.csproj

--- 



