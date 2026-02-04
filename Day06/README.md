# Day 06: Classes and Objects

## 📚 Learning Objectives

- Define classes and create objects
- Use properties and auto-properties
- Implement constructors
- Understand object initialization

## 🎯 Topics Covered

- Class definition and instantiation
- Fields and properties
- Auto-implemented properties
- Constructors and object initializers
- The `this` keyword
- Static members

## 🚀 Running the Exercises

```bash
cd Day06/ClassesObjects
dotnet run
```

## 💡 Key Concepts

```csharp
class Person
{
    // Auto-property
    public string Name { get; set; }
    public int Age { get; set; }
    
    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}");
    }
}

// Usage
var person = new Person("Alice", 30);
person.Introduce();
```

## 📖 Resources

- [Classes - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes)
