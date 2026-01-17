## Overview
Quick sample of streams.

| | |
| --------- | --------------------------- |
| Exercise Folder | DateTIme |
| Builds On | Namespaces |
| Time to complete | 20 minutes |

---

## Success Criteria
Your solution should:
- Add a readonly `int Age` property to Employee class
- Calculate age correctly using current date and employee's DateOfBirth
- Account for whether birthday has occurred this year (subtract 1 if birthday hasn't passed yet)
- Display correct age values for multiple employees with different birthdate scenarios
- Handle edge cases (birthday today, birthday tomorrow, etc.)

## Where to find the solution
See [solutions/DateTime](../../solutions/DateTime)

1. Create a readonly property in *Employee* ```int Age { get {...}}```
2. Use today's date and the employees birthdate to calculate the difference in years
3. If the birthday day of year is not past yet, subtract 1 from age 

