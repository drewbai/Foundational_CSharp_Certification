# Day 08: Interfaces and Abstract Classes

## 📚 Learning Objectives

- Design and implement interfaces
- Create abstract classes
- Understand when to use each
- Apply default interface methods

## 🎯 Topics Covered

- Interface declaration
- Multiple interface implementation
- Abstract classes vs interfaces
- Default interface methods (C# 8+)
- Explicit interface implementation

## 🚀 Running the Exercises

```bash
cd Day08/InterfacesAbstract
dotnet run
```

## 💡 Key Concepts

```csharp
interface IDrawable
{
    void Draw();
    
    // Default implementation (C# 8+)
    void Reset() => Console.WriteLine("Reset");
}

class Shape : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}
```

## 📖 Resources

- [Interfaces - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces)
