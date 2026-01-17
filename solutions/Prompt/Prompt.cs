namespace MenuMaker;

public static class Prompt
{
    public static string GetString(string prompt, string? def, int maxLength = 50)
    {
        Console.Write($"{prompt} ({def}): ");
        string? input = Console.ReadLine()?.Trim();
        if (input?.Length > maxLength)
            throw new ArgumentException($"Input must be less than {maxLength} characters.");
        else if (string.IsNullOrEmpty(input))
            return def ?? string.Empty;
        return input ?? string.Empty;
    }

    public static int GetInt(string prompt, int def=0, int min = 0, int max = 100)
    {
        Console.Write($"{prompt} ({def}): ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
            return def;
        while (true)
        {
            if (int.TryParse(input, out int i) &&
                i >= min && i <= max)
                return i;
            Console.WriteLine($"Input must be between {min} and {max}.");
        }
    }

    public static double GetDouble(string prompt, double def=0, double min = 0, double max = 10_000)
    {
        Console.Write($"{prompt} ({def}): ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
            return def;
        while (true)
        {
            if (double.TryParse(input, out double i) &&
                i >= min && i <= max)
                return i;
            Console.WriteLine($"Input must be between {min} and {max}.");
        }
    }

    
    public static DateTime GetDate(string prompt, string def="01/01/1980")
    {
        Console.Write($"{prompt} ({def}): ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
            return DateTime.Parse(def);
        while (true)
        {
            if (DateTime.TryParse(input, out DateTime date))
                return date;
            Console.WriteLine("Invalid date format.");
        }
    }

    public static bool Confirm(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write("Enter 'y' or 'yes' to confirm: ");
        string? input = Console.ReadLine()?.ToLower();
        return input == "y" || input == "yes";
    }
}