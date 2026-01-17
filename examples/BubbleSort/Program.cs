
// declare an array of 20 integers an populate it with random numbers
int[] numbers = new int[20];

// populate the array with random numbers
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(100);

// display the array
Console.WriteLine("Unsorted array:");
foreach (int number in numbers)
    Console.Write(number + ", ");

// sort the array using a bubble sort

// sort the array
bool swapped = true;
int n = numbers.Length-1; // last item to compare
while (swapped)
{
    swapped = false;
    int lastswapped = 1;
    for (int j = 0; j < n; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
            lastswapped = j;
            swapped = true;
        }
    }
    n = lastswapped;
}

// display the sorted array
Console.WriteLine("\nSorted array:");
foreach (int number in numbers)
    Console.Write(number + ", ");
    