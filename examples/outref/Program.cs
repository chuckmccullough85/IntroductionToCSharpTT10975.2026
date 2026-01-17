
int i = 0;
RefExample (ref i);
Console.WriteLine (i);
int[] myArray = new int[] { 1 };
Console.WriteLine ($"Before array length is {myArray.Length}");
NotRefExample (myArray);
Console.WriteLine ($"After 'NotRefExample' array length is {myArray.Length}");
Console.WriteLine ($"Before 'NotRefExample2' {myArray[0]}");
NotRefExample2 (myArray);
Console.WriteLine ($"After 'NotRefExample2' {myArray[0]}");

Console.WriteLine ($"Before array length is {myArray.Length}");
RefRefExample (ref myArray);
Console.WriteLine ($"After 'RefRefExample' array length is {myArray.Length}");

var r = F2C (32, out double c);
Console.WriteLine ($"32F is {c}C");

bool F2C (double fahrenheit, out double celsius)
{
    if (fahrenheit < -459.67)
    {
        celsius = 0;
        return false;
    }
    celsius = (fahrenheit - 32) * 5 / 9;
    return true;
}   

void RefExample (ref int x)
{
    // change the caller's variable to 10
    x = 10;
}

void NotRefExample (int[] array)
{
    // This line has no effect
    array = new int[] { 10, 20, 30 };
}
void NotRefExample2 (int[] array)  // arrays are reference types
{
    // Change the first element of the caller's array
    array[0] = 10;
    // This line has no effect
    array = new int[] { 10, 20, 30 };  
}
// passing the reference by reference.
void RefRefExample (ref int[] array) 
{
    //This method can change the reference's value
    array = new int[] { 10, 20, 30 };
}
