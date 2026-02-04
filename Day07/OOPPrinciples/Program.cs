// Day 07: OOP Principles
// Topics: Encapsulation, Inheritance, Polymorphism, Virtual Methods

namespace OOPPrinciples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 07: OOP Principles ===\n");

        // Inheritance and polymorphism
        Animal[] animals = {
            new Dog("Buddy"),
            new Cat("Whiskers"),
            new Bird("Tweety")
        };

        foreach (var animal in animals)
        {
            animal.Introduce();
            animal.MakeSound();
            animal.Move();
            Console.WriteLine();
        }

        // Encapsulation
        var employee = new Employee("Alice", 50000m);
        employee.DisplayInfo();
        employee.GiveRaise(5000m);
        employee.DisplayInfo();

        Console.WriteLine("\n=== Day 07 Complete! ===");
    }
}

// Base class
class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving");
    }

    public void Introduce()
    {
        Console.WriteLine($"I am {Name}, a {GetType().Name}");
    }
}

// Derived classes
class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is running");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is sneaking");
    }
}

class Bird : Animal
{
    public Bird(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Chirp chirp!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is flying");
    }
}

// Encapsulation example
class Employee
{
    private decimal salary;  // Private field

    public string Name { get; private set; }

    public decimal Salary
    {
        get => salary;
        private set
        {
            if (value >= 0)
                salary = value;
        }
    }

    public Employee(string name, decimal initialSalary)
    {
        Name = name;
        Salary = initialSalary;
    }

    public void GiveRaise(decimal amount)
    {
        if (amount > 0)
        {
            Salary += amount;
            Console.WriteLine($"{Name} received a raise of ${amount}");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Salary: ${Salary:N2}");
    }
}
