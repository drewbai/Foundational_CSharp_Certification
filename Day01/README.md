# Day 01: C# Fundamentals

## 📚 Learning Objectives

- Understand basic C# syntax and structure
- Master console input and output operations
- Work with primitive data types and variables
- Apply basic arithmetic and logical operators
- Perform string manipulation and formatting

## 🎯 Topics Covered

### 1. Console I/O
- `Console.WriteLine()` vs `Console.Write()`
- `Console.ReadLine()` for user input
- Escape sequences (`\n`, `\t`, `\"`)

### 2. Variables and Data Types
- **Integer types**: `int`, `long`, `short`, `byte`
- **Floating-point**: `double`, `decimal`, `float`
- **Boolean**: `bool`
- **Character and String**: `char`, `string`
- **Implicit typing**: `var` keyword

### 3. Operators
- **Arithmetic**: `+`, `-`, `*`, `/`, `%`
- **Increment/Decrement**: `++`, `--`
- **Comparison**: `==`, `!=`, `<`, `>`, `<=`, `>=`
- **Logical**: `&&`, `||`, `!`

### 4. String Operations
- String concatenation with `+`
- String interpolation with `$""`
- Common string methods: `ToUpper()`, `ToLower()`, `Trim()`, `Replace()`, `Contains()`

## 🚀 Running the Exercises

```bash
cd Day01/CSharpFundamentals
dotnet run
```

## 💡 Key Concepts

### String Interpolation (Modern C#)
```csharp
string name = "Alice";
int age = 30;
Console.WriteLine($"{name} is {age} years old.");
```

### Type-Safe Parsing
```csharp
if (int.TryParse(input, out int result))
{
    // Use result safely
}
```

### Nullable Reference Types
```csharp
string? nullable = Console.ReadLine(); // May be null
```

## 🔍 Practice Challenges

1. Create a simple calculator that takes two numbers and an operator
2. Build a temperature converter (Celsius to Fahrenheit)
3. Write a program that formats user information in a professional business card format

## 📖 Additional Resources

- [C# Fundamentals - Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/)
- [Console Class Documentation](https://learn.microsoft.com/en-us/dotnet/api/system.console)
- [String Interpolation Guide](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

## ✅ Completion Checklist

- [x] Console output methods
- [x] Variable declarations
- [x] Basic operators
- [x] String formatting
- [x] User input handling
