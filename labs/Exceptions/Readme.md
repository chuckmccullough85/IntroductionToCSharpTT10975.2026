## Overview
Property setters should validate candidate data - that really is the reason we have them.

| | |
| --------- | --------------------------- |
| Exercise Folder | Exceptions |
| Builds On | Class Members |
| Time to complete | 15 minutes |

---

## Success Criteria
Your solution should:
- Throw `ArgumentException` when salary is set outside valid range (50-1000)
- Include descriptive error messages indicating the constraint violated
- Handle exceptions gracefully in Program.cs with try/catch block
- Demonstrate proper exception handling with both valid and invalid data

## Where to find the solution
See [solutions/Exceptions](../../solutions/Exceptions)
## Instructions
Continue with the previous lab.

1. Use the VS quick refactorings to switch the Employee.Salary set method back to a method body
1. If **value** is less than 50 or more than 1000, throw an **ArgumentException**
1. In *Program.cs*  create a **try** block and attempt to create an *Employee* with a negative salary

---


