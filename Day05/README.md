# Day 05: Methods and Parameters

## 📚 Learning Objectives

- Declare and invoke methods
- Use parameter modifiers (ref, out, in, params)
- Work with optional and named parameters
- Apply expression-bodied members
- Implement local functions

## 🎯 Topics Covered

### 1. Basic Methods
- Method declaration and return types
- Parameters and arguments
- Method overloading
- Return values

### 2. Parameter Modifiers
- `ref` - Pass by reference
- `out` - Output parameters
- `in` - Read-only reference
- `params` - Variable number of parameters

### 3. Optional and Named Parameters
- Default parameter values
- Named arguments
- Mixing positional and named

### 4. Expression-bodied Members
- Expression-bodied methods `=>`
- Expression-bodied properties
- Expression-bodied constructors

### 5. Local Functions
- Functions within methods
- Closures and variable capture
- Static local functions

## 🚀 Running the Exercises

```bash
cd Day05/MethodsParameters
dotnet run
```

## 💡 Key Concepts

### Parameter Modifiers
```csharp
// ref - must be initialized before passing
int x = 10;
Increment(ref x);

// out - doesn't need initialization
bool success = int.TryParse("123", out int result);

// in - read-only reference (no copy)
void Process(in LargeStruct data) { }

// params - variable arguments
int Sum(params int[] numbers) => numbers.Sum();
```

### Expression-bodied Members
```csharp
// Method
int Square(int x) => x * x;

// Property
public double PI => 3.14159;

// Constructor
public Person(string name) => Name = name;
```

### Local Functions
```csharp
void ProcessData()
{
    int multiplier = 2;
    int Double(int x) => x * multiplier;  // Can capture variables
    
    static int Triple(int x) => x * 3;    // Cannot capture
}
```

## 🔍 Practice Challenges

1. Create a calculator with methods for all basic operations
2. Build a string utilities class with various text manipulation methods
3. Implement a recursive function with local helper functions

## 📖 Additional Resources

- [Methods - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- [Parameter Modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters)
- [Local Functions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)

## ✅ Completion Checklist

- [x] Basic method declaration and invocation
- [x] Parameter modifiers (ref, out, in, params)
- [x] Optional and named parameters
- [x] Expression-bodied members
- [x] Local functions
