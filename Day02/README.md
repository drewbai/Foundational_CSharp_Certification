# Day 02: Data Types and Variables

## 📚 Learning Objectives

- Understand value types vs reference types
- Master type conversion and casting
- Work with nullable types
- Perform advanced string manipulation
- Use constants and readonly fields

## 🎯 Topics Covered

### 1. Value Types
- Numeric types: `byte`, `short`, `int`, `long`, `float`, `double`, `decimal`
- Other: `bool`, `char`, `struct`
- Memory behavior: stored on stack, copied on assignment

### 2. Reference Types
- `string`, arrays, classes
- Memory behavior: stored on heap, reference copied
- Nullable reference types in modern C#

### 3. Type Conversion
- **Implicit**: Automatic safe conversion
- **Explicit**: Manual casting with possible data loss
- **Parse**: `int.Parse()`, `double.Parse()`
- **TryParse**: Safe parsing with error handling
- **Convert**: `Convert.ToInt32()`, etc.

### 4. String Operations
- Immutability of strings
- Common methods: `Trim()`, `Substring()`, `Replace()`, `Split()`, `Join()`
- `StringBuilder` for efficient concatenation
- String formatting and interpolation

### 5. Constants and Readonly
- `const`: Compile-time constants
- `readonly`: Runtime constants
- Default values for types

## 🚀 Running the Exercises

```bash
cd Day02/DataTypesVariables
dotnet run
```

## 💡 Key Concepts

### Value vs Reference Types
```csharp
// Value type - copied
int a = 5;
int b = a;
b = 10;  // a is still 5

// Reference type - shared reference
int[] arr1 = {1, 2, 3};
int[] arr2 = arr1;
arr2[0] = 99;  // arr1[0] is also 99
```

### Safe Type Conversion
```csharp
if (int.TryParse(input, out int result))
{
    // Use result safely
}
else
{
    // Handle invalid input
}
```

### Nullable Types
```csharp
int? nullable = null;
int value = nullable ?? -1;  // Null-coalescing operator
```

## 🔍 Practice Challenges

1. Create a BMI calculator with proper type handling
2. Build a string formatter for addresses (name, street, city, zip)
3. Write a type conversion utility that handles multiple formats

## 📖 Additional Resources

- [Value Types - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
- [Type Conversion](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- [Nullable Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)

## ✅ Completion Checklist

- [x] Value types and sizes
- [x] Reference type behavior
- [x] Type conversion methods
- [x] String manipulation
- [x] Constants and readonly
