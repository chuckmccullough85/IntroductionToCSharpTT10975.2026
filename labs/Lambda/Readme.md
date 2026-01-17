## Overview
This lab demonstrates lambda expressions.

| | |
| --------- | --------------------------- |
| Exercise Folder | Lambda |
| Builds On | Delegates |
| Time to complete | 10 minutes |

## Success Criteria
Your solution should:
- Define counter variable initialized to 0
- Assign lambda expression to PayProcessor property: `p => count++`
- Call Pay() method to trigger callback
- Display final count of paid employees
- Demonstrate lambda syntax and closure behavior

## Where to find the solution
See [solutions/Lambda](../../solutions/Lambda)

---

Let's count how many employees get paid in the top level code
1. Define a counter initialized to 0
2. Assign to PayProcessor a lambda that increments the counter
3. Call Pay()
4. Display the counter

```c#
int count = 0;
acme.PayProcessor = p => count++;
acme.Pay();
Console.WriteLine($"We paid {count} employees");
```
