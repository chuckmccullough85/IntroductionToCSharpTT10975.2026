
Dog d1 = new Dog("Fido", 10);
Dog d2 = new Dog("Rover", 12);

d1.Speak();
d2.Speak();
d1.Exercise();
d2.Eat();
d1.Speak();
d2.Speak();

d1.Eat();
d1.Eat();
d1.Speak();

var bigCircle = new Circle(100);
var smallCircle = new Circle(1);
Console.WriteLine($"Big circle area: {bigCircle.Area}");
Console.WriteLine($"Small circle area: {smallCircle.Area}");

Console.Write("Enter a radius: ");
var radius = double.Parse(Console.ReadLine()!);
var userCircle = new Circle(radius);
Console.WriteLine($@"User circle area: {userCircle.Area},  
circumference: {userCircle.Circumference}");


class Circle
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area
    {
        get { return Math.PI * _radius * _radius; }
        set { _radius = Math.Sqrt(value / Math.PI); }
    } 
    public double Circumference
    {
        get { return 2 * Math.PI * _radius; }
        set { _radius = value / (2 * Math.PI); }
    }
    public double Diameter
    {
        get { return 2 * _radius; }
        set { _radius = value / 2; }
    }
    public double Radius
    {
        get { return _radius; }
        set 
        { 
            if (value >= 0)
                _radius = value; 
        }
    }
}


// class Circle
// {
//     // Fields
//     public double _radius;

//     // Constructor
//     public Circle(double radius)
//     {
//         _radius = radius;
//     }

//     // Methods
//     public double GetArea()
//     {
//         return Math.PI * _radius * _radius;
//     }

//     public double GetCircumference()
//     {
//         return 2 * Math.PI * _radius;
//     }

//     public void Print()
//     {
//         Console.WriteLine("Radius: " + _radius);
//         Console.WriteLine("Area: " + GetArea());
//         Console.WriteLine("Circumference: " + GetCircumference());
//     }
// }


// A dog class with name, and weight
class Dog
{
    // Fields
    private string _name;
    private double _weight;

    // Constructor
    public Dog(string name, double weight)
    {
        _name = name;
        _weight = weight;
    }

    // Methods
    public void Speak()
    {
        if (_weight > 10)
            Console.WriteLine($"WOOF! ({_name})");
        else
            Console.WriteLine($"yip! ({_name})");
    }

    public void Eat()
    {
        _weight += 0.1;
    }

    public void Exercise()
    {
        _weight -= 0.1;
    }

    public void Print()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Weight: " + _weight);
    }
}