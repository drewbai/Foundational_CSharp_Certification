# Day 11: File I/O and Serialization

## 📚 Learning Objectives

- Perform file system operations
- Read and write files
- Serialize/deserialize JSON
- Work with streams

## 🎯 Topics Covered

- File and Directory classes
- StreamReader and StreamWriter
- JSON serialization with System.Text.Json
- Path manipulation
- File operations (create, read, write, delete)

## 🚀 Running the Exercises

```bash
cd Day11/FileIOSerialization
dotnet run
```

## 💡 Key Concepts

```csharp
using System.Text.Json;

// Write file
File.WriteAllText("data.txt", "Hello, World!");

// Read file
string content = File.ReadAllText("data.txt");

// JSON serialization
var person = new Person { Name = "Alice", Age = 30 };
string json = JsonSerializer.Serialize(person);
var restored = JsonSerializer.Deserialize<Person>(json);
```

## 📖 Resources

- [File I/O - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/standard/io/)
- [JSON Serialization](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-overview)
