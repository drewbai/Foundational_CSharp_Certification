# Day 09: LINQ and Modern C#

## 📚 Learning Objectives

- Write LINQ queries
- Use lambda expressions
- Apply modern C# features
- Work with records

## 🎯 Topics Covered

- LINQ query syntax
- LINQ method syntax
- Lambda expressions
- Records (C# 9+)
- Pattern matching enhancements
- Init-only properties

## 🚀 Running the Exercises

```bash
cd Day09/LinqModernCSharp
dotnet run
```

## 💡 Key Concepts

```csharp
// LINQ
var numbers = new[] { 1, 2, 3, 4, 5 };
var evens = numbers.Where(n => n % 2 == 0).ToList();

// Records
record Person(string Name, int Age);
var person = new Person("Alice", 30);
var older = person with { Age = 31 };
```

## 📖 Resources

- [LINQ - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)
- [Records](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record)
