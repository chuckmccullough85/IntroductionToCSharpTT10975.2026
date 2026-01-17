namespace MenuMaker;

public record MenuItem(string Text, Action<MenuItem> Command);

public class Menu 
{
    private List<MenuItem> _items = new List<MenuItem>();

    public Menu (string title, params (string text, Action<MenuItem> command)[] items)
    {
        Title = title;
        foreach (var item in items)
            _items.Add(new MenuItem (item.text, item.command ));
    }

    public string Title { get; init; }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Title);
        int i = 1;
        foreach (var item in _items)
        {
            Console.WriteLine($"{i++}. {item.Text}");
        }
        Console.WriteLine("0. Exit");
    }
    public void Run()
    {
        while (true)
        {
            Display();
            Console.Write("Enter choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
                continue;
            if (choice == 0)
                break;
            if (choice > 0 && choice <= _items.Count)
                _items[choice - 1].Command(_items[choice - 1]);
        }
    }
}