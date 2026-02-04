# Day 12: Error Handling and Testing

## 📚 Learning Objectives

- Handle exceptions properly
- Write unit tests
- Use try-catch-finally
- Apply test-driven development

## 🎯 Topics Covered

- Exception handling
- try-catch-finally blocks
- Custom exceptions
- Unit testing with xUnit
- Assertions and test patterns
- Arrange-Act-Assert

## 🚀 Running the Exercises

```bash
cd Day12/ErrorHandlingTesting
dotnet run
dotnet test  # If tests are added
```

## 💡 Key Concepts

```csharp
// Exception handling
try
{
    int result = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Cleanup");
}

// Custom exception
class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}
```

## 📖 Resources

- [Exception Handling - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- [Unit Testing](https://learn.microsoft.com/en-us/dotnet/core/testing/)
