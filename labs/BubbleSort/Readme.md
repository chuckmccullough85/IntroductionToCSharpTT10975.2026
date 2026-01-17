## Overview

Let's sort an array of strings!

| | |
| --------- | --------------------------- |
| Exercise Folder | BubbleSort |
| Builds On | None |
| Time to complete | 60 minutes

Apply what you learned about sorting to sort an array of strings.

### Setup
* Create a new console project and copy and paste the code below into your main file.
* The array *names* is initialized with some random names.  We used an array initializer to do this.  The compiler will figure out the size of the array.
* Each element of the array is of type *string*.
* Use a `foreach` loop to print out the original contents of the array.

```c#
// some names to sort
string[] names = {
		"Hill, Hank",
		"Hill, Peggy",
		"Platter, Luanne",
		"Platter, Lucky",
		"Strickland, Buck",
		"Souphanousinphone, Minh",
		"Boomhauer, Jeff",
		"Gribble, Dale",
		"Gribble, Nancy",
		"Souphanousinphone, Kahn",
		"Dauterive, Bill",
		"Dauterive, Lenore",
		"Redcorn, John",
		"Souphanousinphone, Connie"
	};

// display the array
Console.WriteLine("Unsorted array:");
foreach (string name in names)
    Console.WriteLine(name);```
```

### Steps

1. declare a variable to hold the number of elements in the array - 1.  This will be the number of times we need to iterate through the array (at most).  Name the variable *maxIndex*
1. declare a boolean variable to indicate if a swap was made during the last iteration.  Initialize it to true.  Name the variable *swapped*.
1. use a while for the outer loop.  Loop until *swapped* is false.
1. Inside the while loop, 
	* set *swapped* to false.
	* declare a temporary variable *lastswapped* and set it to 1.
* Now, use a for loop to iterate through the array.  The loop should start at 0 and end at < *maxIndex*.
	* if the array has length 20, the last index is 19.  That's what maxIndex starts with.  The loop should stop at 18 because we will compare the current index with the next index (19).
* In the for loop, compare the current element with the next element.  If the current element is greater than the next element
	* swap them (use a temporary variable)
	* set *swapped* to true.
	* set *maxIndex* to the current index.  This will reduce the number of times we need to iterate through the array.  At worst, *maxIndex* will be 1 smaller each time through the loop, but it could be more.

---

* Lastly, loop through the array and print out the sorted contents.

---
### Challenge
Declare a variable to hold the number of comparisons made during the sort.  Increment the variable each time you compare two elements.

Display the value of the variable after the sort is complete.  How many comparisons were made? How can that change with the input data and with the algorithm?

  * for instance, just decrementing maxIndex after each outer loop will result in more comparisons.  We counted 85 with a simple decrement vs 73 with tracking the last swapped index.
  * also, looping the outer loop until maxIndex is 0 will result in more comparisons.  We counted 91 with this approach.
	

You will notice that increasing the number of elements in the array just a little increases the number of comparisons a lot!

### Success criteria
- Initial array is displayed unsorted, then displayed sorted in ascending order.
- Sorting algorithm minimizes unnecessary comparisons by tracking last swap index.

### Where to find the solution
For reference, see the completed example in:
- solutions/BubbleSortSolution/BubbleSortSolution.csproj


