## Overview
This lab demonstrates interfaces.

| | |
| --------- | --------------------------- |
| Exercise Folder | Interface |
| Builds On | Inheritance |
| Time to complete | 40 minutes |

---

## Success Criteria
Your solution should:
- Define `Payable` interface with required `Pay()` method
- Update Organization to use `List<Payable>` instead of HumanResource type
- Implement Payable in both Employee and Contractor classes
- Support any class implementing Payable (Vendor, Robot, etc.)
- Demonstrate loose coupling through interface dependency
- Bonus: Create a Robot or other class implementing Payable

## Where to find the solution
See [solutions/Interface](../../solutions/Interface)
## Instructions
Continue with the previous lab.

*Organizaton* had a dependency on *Employee*, which was inflexible.  In order to also hire *Contractors*, we define a common type *HumanResource*.

But this is still inflexible.  What if we wanted to hire another company to provide a service?  We could define a class like *Vendor* and inherit from *HumanResource*, but that's not a good fit.  A vendor doesn't have an id number or birthdate (at least that we care about).

In object-oriented design, a class that depends on another class should decouple by defining the exact interface that it requires.  *Organization* only uses *Pay* in *HumanResource*.  It never uses any of the other properties or methods, yet it is dependent on them.  We can fix that by custom designing an exact fit with an interface.

### Steps
1. Create a new interface named *Payable*
1. Define a single method *float Pay()* in the interface
1. Replace all occurances of *HumanResource* with *Payable* in the *Organization* class
1. Add *Payable* to the implements list of *HumanResource*

**Challenge**
1. Create a new class *Robot* that implements *Payable*
1. Hire some robots

---


### Want More?

![Youtube.com](https://youtu.be/fIyucuUhiSA)
