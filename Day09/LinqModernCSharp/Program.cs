// Day 09: LINQ and Modern C#
// Topics: LINQ Queries, Lambda Expressions, Records

using System.Linq;

namespace LinqModernCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 09: LINQ and Modern C# ===\n");

        // LINQ with collections
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine($"Even numbers: [{string.Join(", ", evens)}]");

        var squared = numbers.Select(n => n * n);
        Console.WriteLine($"Squared: [{string.Join(", ", squared)}]");

        var filtered = numbers.Where(n => n > 5).Select(n => n * 2);
        Console.WriteLine($"Filtered and doubled: [{string.Join(", ", filtered)}]");

        // Working with complex objects
        var people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("Diana", 28)
        };

        var adults = people.Where(p => p.Age >= 30).OrderBy(p => p.Name);
        Console.WriteLine("\nAdults (30+):");
        foreach (var person in adults)
        {
            Console.WriteLine($"  {person}");
        }

        // Records (C# 9+)
        var product1 = new Product("Laptop", 999.99m);
        var product2 = product1 with { Price = 899.99m };

        Console.WriteLine($"\nOriginal: {product1}");
        Console.WriteLine($"Discounted: {product2}");

        Console.WriteLine("\n=== Day 09 Complete! ===");
    }
}

// Record type
record Person(string Name, int Age);

record Product(string Name, decimal Price);
