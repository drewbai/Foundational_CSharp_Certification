# Day 10: Async/Await and Tasks

## 📚 Learning Objectives

- Understand asynchronous programming
- Use async/await keywords
- Work with Task and Task<T>
- Apply async best practices

## 🎯 Topics Covered

- Task-based asynchronous pattern
- async/await keywords
- Task.Run for CPU-bound work
- Async methods and return types
- ConfigureAwait
- Parallel operations

## 🚀 Running the Exercises

```bash
cd Day10/AsyncAwait
dotnet run
```

## 💡 Key Concepts

```csharp
async Task<string> FetchDataAsync()
{
    await Task.Delay(1000);  // Simulate async operation
    return "Data fetched";
}

// Usage
var result = await FetchDataAsync();
Console.WriteLine(result);
```

## 📖 Resources

- [Async Programming - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)
