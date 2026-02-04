# Day 04: Arrays and Collections

## 📚 Learning Objectives

- Work with arrays and multi-dimensional arrays
- Master List<T> operations
- Use Dictionary<K,V> for key-value pairs
- Explore specialized collections (HashSet, Queue, Stack)
- Perform common collection operations

## 🎯 Topics Covered

### 1. Arrays
- Single-dimensional arrays
- Multi-dimensional arrays `[,]`
- Jagged arrays `[][]`
- Array methods: `Sort`, `Reverse`, `IndexOf`
- Index from end operator `^`

### 2. Lists
- `List<T>` declaration and initialization
- Add, Insert, Remove operations
- Find, FindAll, Contains
- Collection initializers
- Sorting and filtering

### 3. Dictionaries
- `Dictionary<K,V>` basics
- Add, Update, Remove operations
- `TryGetValue` for safe access
- Keys and Values collections
- ContainsKey, ContainsValue

### 4. Other Collections
- `HashSet<T>` for unique elements
- Set operations (Union, Intersect)
- `Queue<T>` (FIFO)
- `Stack<T>` (LIFO)

### 5. Collection Operations
- LINQ basics (preview)
- Aggregation: Sum, Average, Min, Max
- Filtering and transformation
- Collection expressions (C# 12+)

## 🚀 Running the Exercises

```bash
cd Day04/ArraysCollections
dotnet run
```

## 💡 Key Concepts

### Collection Initializers
```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Dictionary<string, int> ages = new Dictionary<string, int>
{
    { "Alice", 30 },
    { "Bob", 25 }
};
```

### Safe Dictionary Access
```csharp
if (dict.TryGetValue(key, out var value))
{
    // Use value safely
}
```

### Modern Collection Expressions
```csharp
int[] arr = [1, 2, 3];
int[] combined = [..arr1, ..arr2];  // Spread operator
```

## 🔍 Practice Challenges

1. Create a shopping cart using Dictionary<Product, int>
2. Build a playlist manager using List<Song>
3. Implement a simple stack-based calculator

## 📖 Additional Resources

- [Arrays - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
- [Collections](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)
- [Generic Collections](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic)

## ✅ Completion Checklist

- [x] Arrays and multi-dimensional arrays
- [x] List<T> operations
- [x] Dictionary<K,V> usage
- [x] Specialized collections
- [x] Collection operations and LINQ preview
