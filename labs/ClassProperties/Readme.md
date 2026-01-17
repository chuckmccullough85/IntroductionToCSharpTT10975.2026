
## Overview
Add some properties to Employee

| | |
| --------- | --------------------------- |
| Exercise Folder | ClassProperties |
| Builds On | BasicClasses |
| Time to complete | 30 minutes |

---

## Success Criteria
Your `Employee` class should:
- Validate salary range (50-5000) and reject invalid values
- Validate id is unsigned and read-only after construction
- Validate name is not null or empty
- Keep YTD properties read-only
- Display clear error messages for invalid input

## Where to find the solution
See [solutions/ClassProperties](../../solutions/ClassProperties)
## Instructions
Our existing employee class is not encapsulted.  We can access and change the data fields directly.  A careless programmer could easily give the employee a negative salary or invalid id.  The YTD values can be manipulated without corresponding payments.  We need to add some properties to the class to prevent this.

### Steps
1. Add a property for the employee's id.  The id should be read-only.  It should be set in the constructor and not changed after that.  Change the type of id to *unsigned int*.
2. Add a property for the employee's salary.  A salary must be between 50 and 5000.
3. Add a property for the employee's YTD gross pay.  This should be read-only. 
4. Add a property for the employee's YTD taxes.  This should be read-only.
5. Add a property for the employee's name.  The name should be not null and not empty.  *Hint - check out string.IsNullOrEmpty()*
6. Change the constructor to use the properties instead of the data fields.
  * the get/set methods do not have to have the same visibility.  For example, the get method can be public and the set method can be private.
7. Change all the fields to private.
8. Update *Program.cs* to use the new properties.
---
