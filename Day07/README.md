# Day 07: OOP Principles

## 📚 Learning Objectives

- Apply encapsulation
- Implement inheritance
- Use polymorphism
- Override methods

## 🎯 Topics Covered

- Encapsulation and access modifiers
- Inheritance with base classes
- Method overriding with `virtual` and `override`
- Abstract classes
- Polymorphism

## 🚀 Running the Exercises

```bash
cd Day07/OOPPrinciples
dotnet run
```

## 💡 Key Concepts

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
```

## 📖 Resources

- [OOP - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)
