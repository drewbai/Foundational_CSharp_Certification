// Day 11: File I/O and Serialization
// Topics: File Operations, JSON Serialization

using System.Text.Json;

namespace FileIOSerialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 11: File I/O and Serialization ===\n");

        string filePath = "data.txt";
        string jsonPath = "person.json";

        // Write text to file
        File.WriteAllText(filePath, "Hello from Day 11!");
        Console.WriteLine($"Wrote to {filePath}");

        // Read text from file
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"Read from {filePath}: {content}");

        // JSON serialization
        var person = new Person { Name = "Alice", Age = 30, Email = "alice@example.com" };
        string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonPath, json);
        Console.WriteLine($"\nSerialized to {jsonPath}:");
        Console.WriteLine(json);

        // JSON deserialization
        string loadedJson = File.ReadAllText(jsonPath);
        var loadedPerson = JsonSerializer.Deserialize<Person>(loadedJson);
        Console.WriteLine($"\nDeserialized: {loadedPerson?.Name}, {loadedPerson?.Age}, {loadedPerson?.Email}");

        // Cleanup
        File.Delete(filePath);
        File.Delete(jsonPath);
        Console.WriteLine("\nCleanup complete");

        Console.WriteLine("\n=== Day 11 Complete! ===");
    }
}

class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Email { get; set; } = "";
}
