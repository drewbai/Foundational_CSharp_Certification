# Day 03: Control Flow

## 📚 Learning Objectives

- Master conditional statements (if, else, switch)
- Implement various loop structures
- Apply modern C# pattern matching
- Use break and continue effectively
- Understand control flow best practices

## 🎯 Topics Covered

### 1. Conditional Statements
- `if`, `else if`, `else`
- Ternary operator `? :`
- Logical operators: `&&`, `||`, `!`
- Null-conditional operator `?.`

### 2. Switch Statements
- Traditional switch-case
- Switch expressions (C# 8+)
- Pattern matching in switch
- `when` clauses

### 3. For Loops
- Basic `for` loop
- `foreach` loop
- Nested loops
- `break` and `continue`

### 4. While Loops
- `while` loop
- `do-while` loop
- Infinite loops with break
- Loop control flow

### 5. Pattern Matching
- Type patterns with `is`
- Property patterns
- Relational patterns
- List patterns (C# 11+)

## 🚀 Running the Exercises

```bash
cd Day03/ControlFlow
dotnet run
```

## 💡 Key Concepts

### Switch Expression (Modern C#)
```csharp
string result = value switch
{
    1 => "One",
    2 => "Two",
    >= 3 and <= 5 => "Three to Five",
    _ => "Other"
};
```

### Pattern Matching
```csharp
if (obj is string { Length: > 0 } str)
{
    Console.WriteLine($"Non-empty string: {str}");
}
```

### Foreach with Modern Features
```csharp
foreach (var (index, item) in items.Select((val, i) => (i, val)))
{
    Console.WriteLine($"{index}: {item}");
}
```

## 🔍 Practice Challenges

1. Create a number guessing game with input validation
2. Build a menu-driven calculator using switch expressions
3. Write a pattern matching-based object classifier

## 📖 Additional Resources

- [Selection Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)
- [Iteration Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)
- [Pattern Matching](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching)

## ✅ Completion Checklist

- [x] If-else statements
- [x] Switch and switch expressions
- [x] For and foreach loops
- [x] While and do-while loops
- [x] Modern pattern matching
