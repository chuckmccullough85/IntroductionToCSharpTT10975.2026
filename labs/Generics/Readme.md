## Overview
In this lab, we get a sneak peek at a .Net library class, *List<E>*, a generic class designed to hold objects.

| | |
| --------- | --------------------------- |
| Exercise Folder | Generics |
| Builds On | Exceptions |
| Time to complete | 30 minutes |

---

## Success Criteria
Your solution should:
- Create `Organization` class with Name and TaxId properties
- Use `List<Employee>` to manage employees (1-to-many relationship)
- Implement `Hire(Employee)` and `Terminate(Employee)` methods
- Implement `Pay()` method that calculates total payroll for all employees
- Support querying employee count and accessing employees in the list

## Where to find the solution
See [solutions/Generics](../../solutions/Generics)
## Instructions
Continue with the previous lab [DateTime](../../solutions/DateTime/).

According to our SME (subject matter expert), the payroll system needs the ability to define organizations.  Organizations will hire employees and pay them.  This creates a 1->many relationship.  We could define an array of employees within organization, but arrays are inflexible and the employee count for organizations will go up and down.

A better choice is to use a collection class.  Collections (more later) are data structures and algorithms for storing, navigating, searching, and sorting many objects.  The simplest collection is *List*.

Let's create the organization!

### Steps
1. Create a new class in your project named *Organization*.
1. An *Organization* has
    1. a name
    1. a tax id
    1. an address
    1. many employees
1. So, define auto properties for each of the attributes above in the organization class
1. For the employees, use ```List<Employee>```
1. The organization will also need a method for adding, removing and paying employees
    1. ```public void Hire(Employee e)```
    1. ```public void Terminate (Employee e)```
    1. ```public float Pay()```
1. Add and implement the above methods
    - hint: use ```foreach``` to iterate through the employees
1. In *Program.cs* create an organization and hire the employees you have already created (and more if you wish).
1. Call *Pay* then verify that the employees were paid by looking at their YTD values

---

[Solution](/api/user/File/1315)