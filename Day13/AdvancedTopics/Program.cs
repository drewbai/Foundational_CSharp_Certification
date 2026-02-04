// Day 13: Advanced Topics
// Topics: Generics, Extension Methods, Nullable Reference Types

namespace AdvancedTopics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 13: Advanced Topics ===\n");

        // Generics
        var intContainer = new Container<int>(42);
        var stringContainer = new Container<string>("Hello");

        Console.WriteLine($"Int container: {intContainer.Value}");
        Console.WriteLine($"String container: {stringContainer.Value}");

        // Generic methods
        int max = GetMax(10, 20);
        string maxStr = GetMax("apple", "banana");
        Console.WriteLine($"Max int: {max}");
        Console.WriteLine($"Max string: {maxStr}");

        // Extension methods
        string text = "  hello world  ";
        Console.WriteLine($"\nOriginal: '{text}'");
        Console.WriteLine($"Is empty: {text.IsEmpty()}");
        Console.WriteLine($"Word count: {text.WordCount()}");

        // Nullable reference types
        string? nullable = null;
        Console.WriteLine($"\nNullable string length: {nullable?.Length ?? 0}");

        Console.WriteLine("\n=== Day 13 Complete! ===");
    }

    static T GetMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}

// Generic class
class Container<T>
{
    public T Value { get; set; }

    public Container(T value)
    {
        Value = value;
    }
}

// Extension methods
static class StringExtensions
{
    public static bool IsEmpty(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;
        return str.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
