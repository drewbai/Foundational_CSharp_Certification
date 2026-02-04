# Day 13: Advanced Topics

## 📚 Learning Objectives

- Use generics effectively
- Create extension methods
- Work with nullable reference types
- Apply advanced C# features

## 🎯 Topics Covered

- Generic classes and methods
- Generic constraints
- Extension methods
- Nullable reference types
- Attributes
- Reflection basics

## 🚀 Running the Exercises

```bash
cd Day13/AdvancedTopics
dotnet run
```

## 💡 Key Concepts

```csharp
// Generics
class Container<T>
{
    public T Value { get; set; }
}

// Extension method
static class StringExtensions
{
    public static bool IsEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}

// Usage
string text = "Hello";
bool empty = text.IsEmpty();
```

## 📖 Resources

- [Generics - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics)
- [Extension Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
