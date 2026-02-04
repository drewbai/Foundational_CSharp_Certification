// Day 08: Interfaces and Abstract Classes
// Topics: Interface Design, Abstract Classes, Multiple Interfaces

namespace InterfacesAbstract;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 08: Interfaces and Abstract Classes ===\n");

        // Working with interfaces
        IDrawable[] drawables = {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4)
        };

        foreach (var shape in drawables)
        {
            shape.Draw();
            if (shape is IResizable resizable)
            {
                resizable.Resize(1.5);
            }
        }

        Console.WriteLine();

        // Working with abstract classes
        Vehicle[] vehicles = {
            new Car("Tesla Model 3"),
            new Motorcycle("Harley Davidson"),
            new Bicycle("Mountain Bike")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Move();
            vehicle.Stop();
            Console.WriteLine();
        }

        Console.WriteLine("=== Day 08 Complete! ===");
    }
}

// Interface definitions
interface IDrawable
{
    void Draw();
}

interface IResizable
{
    void Resize(double factor);
}

// Classes implementing interfaces
class Circle : IDrawable, IResizable
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }

    public void Resize(double factor)
    {
        Radius *= factor;
        Console.WriteLine($"Circle resized. New radius: {Radius:F2}");
    }
}

class Rectangle : IDrawable, IResizable
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a rectangle {Width} x {Height}");
    }

    public void Resize(double factor)
    {
        Width *= factor;
        Height *= factor;
        Console.WriteLine($"Rectangle resized. New dimensions: {Width:F2} x {Height:F2}");
    }
}

class Triangle : IDrawable
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a triangle with base {Base} and height {Height}");
    }
}

// Abstract class
abstract class Vehicle
{
    public string Name { get; set; }

    protected Vehicle(string name)
    {
        Name = name;
    }

    // Abstract method - must be implemented
    public abstract void Move();

    // Virtual method - can be overridden
    public virtual void Start()
    {
        Console.WriteLine($"{Name} is starting...");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"{Name} is stopping...");
    }
}

// Derived classes
class Car : Vehicle
{
    public Car(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} is driving on the road");
    }

    public override void Start()
    {
        Console.WriteLine($"{Name} engine starting with ignition");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} is riding fast");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} is pedaling");
    }

    public override void Start()
    {
        Console.WriteLine($"{Name} ready to ride (no engine)");
    }
}
