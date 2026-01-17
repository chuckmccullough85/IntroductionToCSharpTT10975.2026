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
		"Souphanousinphone, Connie",
        "Judge, Mike",
        "Morgendorffer, Daria",
        "Morgendorffer, Quinn",
        "Lane, Jane",
        "Lane, Trent",
        "Griffin, Peter",
        "Griffin, Lois",
        "Griffin, Meg",
        "Flintstone, Fred",
        "Flintstone, Wilma"
	};

// display the array
Console.WriteLine("Unsorted array:");
foreach (string name in names)
    Console.WriteLine(name);

int comparisons = 0; // count comparisons

// sort the array
bool swapped = true;
int maxIndex = names.Length-1; // last item to compare
while (swapped)
{
    swapped = false;
    int lastswapped = 1;
    for (int j = 0; j < maxIndex; j++)
    {
        comparisons++;
        if (names[j].CompareTo(names[j + 1]) > 0)
        {
            string temp = names[j];
            names[j] = names[j + 1];
            names[j + 1] = temp;
            lastswapped = j;
            swapped = true;
        }
    }
    maxIndex = lastswapped;
}

Console.WriteLine($"Total comparisons: {comparisons}");
// display the sorted array
Console.WriteLine("\nSorted array:");
foreach (string name in names)
    Console.WriteLine(name);

    