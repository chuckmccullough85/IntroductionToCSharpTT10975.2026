class Program
{
    // Method Overloading
    static void Display(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    static void Display(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // Default Parameters
    static void Greet(string name = "User")
    {
        Console.WriteLine("Hello, " + name);
    }

    // Params Keyword
    static void Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        Console.WriteLine("Sum: " + total);
    }

    /// <summary>
    /// This method "grows/shrinks" an existing array to a new size.
    /// </summary>
    /// <param name="newSize">the size of the new array</param>
    /// <param name="array">holds the input and output array</param>
    /// <param name="total">the sum of all elements</param>
    /// <returns>the average element value</returns>
    static float Resize(int newSize, ref int[] array, out int total)
    {
        int[] newArray = new int[newSize];  // allocate new array
        for (int i = 0; i < array.Length && i < newArray.Length; i++)
            newArray[i] = array[i]; // copy elements
        array = newArray; // assign new array to input array
        total = 0;
        foreach (int num in array)
        {
            total += num; // calculate sum
        }
        return (float)total / array.Length;
    }

    static void Main(string[] args)
    {
        Display("Hello World");  // Calls Display(string message)
        Display(123);  // Calls Display(int number)
        Greet();  // Calls Greet(string name) with default parameter
        Sum(1, 2, 3, 4, 5);  // Calls Sum(params int[] numbers)
        
        int[] array = { 1, 2, 3, 4, 5 };
        int total;
        //grow
        var average = Resize(10, ref array, out total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Total: " + total);

        //shrink
        average = Resize(3, ref array, out total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Total: " + total);
    }
}