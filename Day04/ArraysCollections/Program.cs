// Day 04: Arrays and Collections
// Topics: Arrays, Lists, Dictionaries, Collection Initialization

namespace ArraysCollections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 04: Arrays and Collections ===\n");

        Exercise1_Arrays();
        Exercise2_Lists();
        Exercise3_Dictionaries();
        Exercise4_OtherCollections();
        Exercise5_CollectionOperations();

        Console.WriteLine("\n=== Day 04 Complete! ===");
    }

    static void Exercise1_Arrays()
    {
        Console.WriteLine("\n--- Exercise 1: Arrays ---");
        
        // Array declaration and initialization
        int[] numbers = new int[5];  // Default values (0)
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        
        Console.Write("Array: ");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        // Array initialization
        string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
        Console.WriteLine($"Fruits count: {fruits.Length}");
        Console.WriteLine($"First: {fruits[0]}, Last: {fruits[^1]}");  // Index from end
        
        // Multi-dimensional array
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        Console.WriteLine("Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
        
        // Jagged array (array of arrays)
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6, 7, 8, 9 };
        
        Console.WriteLine("Jagged array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write($"Row {i}: ");
            foreach (int val in jagged[i])
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
        }
        
        // Array methods
        int[] unsorted = { 5, 2, 8, 1, 9 };
        Console.WriteLine($"Original: [{string.Join(", ", unsorted)}]");
        Array.Sort(unsorted);
        Console.WriteLine($"Sorted: [{string.Join(", ", unsorted)}]");
        Array.Reverse(unsorted);
        Console.WriteLine($"Reversed: [{string.Join(", ", unsorted)}]");
        
        int index = Array.IndexOf(unsorted, 8);
        Console.WriteLine($"Index of 8: {index}");
    }

    static void Exercise2_Lists()
    {
        Console.WriteLine("\n--- Exercise 2: Lists ---");
        
        // List declaration and initialization
        List<string> cities = new List<string>();
        cities.Add("Seattle");
        cities.Add("Portland");
        cities.Add("San Francisco");
        
        Console.WriteLine($"Cities: [{string.Join(", ", cities)}]");
        
        // Collection initializer
        List<int> primes = new List<int> { 2, 3, 5, 7, 11 };
        Console.WriteLine($"Primes: [{string.Join(", ", primes)}]");
        
        // List operations
        primes.Add(13);
        Console.WriteLine($"After Add(13): [{string.Join(", ", primes)}]");
        
        primes.Insert(0, 1);
        Console.WriteLine($"After Insert(0, 1): [{string.Join(", ", primes)}]");
        
        primes.Remove(1);
        Console.WriteLine($"After Remove(1): [{string.Join(", ", primes)}]");
        
        primes.RemoveAt(0);
        Console.WriteLine($"After RemoveAt(0): [{string.Join(", ", primes)}]");
        
        // List properties and methods
        Console.WriteLine($"Count: {primes.Count}");
        Console.WriteLine($"Contains 7: {primes.Contains(7)}");
        Console.WriteLine($"IndexOf 5: {primes.IndexOf(5)}");
        
        // Range operations
        List<int> moreNumbers = new List<int> { 17, 19, 23 };
        primes.AddRange(moreNumbers);
        Console.WriteLine($"After AddRange: [{string.Join(", ", primes)}]");
        
        // List with complex types
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };
        
        Console.WriteLine("People:");
        foreach (var person in people)
        {
            Console.WriteLine($"  {person.Name}, {person.Age}");
        }
        
        // Find and filter
        var youngPerson = people.Find(p => p.Age < 30);
        Console.WriteLine($"First person under 30: {youngPerson?.Name}");
        
        var adults = people.FindAll(p => p.Age >= 25);
        Console.WriteLine($"Adults (25+): {string.Join(", ", adults.Select(p => p.Name))}");
        
        // Sort list
        primes.Sort();
        Console.WriteLine($"Sorted primes: [{string.Join(", ", primes)}]");
    }

    static void Exercise3_Dictionaries()
    {
        Console.WriteLine("\n--- Exercise 3: Dictionaries ---");
        
        // Dictionary declaration
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 30);
        ages.Add("Bob", 25);
        ages.Add("Charlie", 35);
        
        Console.WriteLine("Dictionary:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
        }
        
        // Collection initializer
        var scores = new Dictionary<string, int>
        {
            { "Math", 95 },
            { "Science", 88 },
            { "English", 92 }
        };
        
        // Dictionary operations
        Console.WriteLine($"\nMath score: {scores["Math"]}");
        
        // Safe access with TryGetValue
        if (scores.TryGetValue("History", out int historyScore))
        {
            Console.WriteLine($"History score: {historyScore}");
        }
        else
        {
            Console.WriteLine("History score not found");
        }
        
        // Update value
        scores["Math"] = 98;
        Console.WriteLine($"Updated Math score: {scores["Math"]}");
        
        // Check for key
        Console.WriteLine($"Contains 'Science': {scores.ContainsKey("Science")}");
        Console.WriteLine($"Contains value 88: {scores.ContainsValue(88)}");
        
        // Keys and values
        Console.WriteLine($"Subjects: [{string.Join(", ", scores.Keys)}]");
        Console.WriteLine($"Scores: [{string.Join(", ", scores.Values)}]");
        
        // Remove
        scores.Remove("English");
        Console.WriteLine($"After removing English: Count = {scores.Count}");
        
        // Iterate different ways
        Console.WriteLine("\nIteration:");
        foreach (var subject in scores.Keys)
        {
            Console.WriteLine($"  {subject}: {scores[subject]}");
        }
    }

    static void Exercise4_OtherCollections()
    {
        Console.WriteLine("\n--- Exercise 4: Other Collections ---");
        
        // HashSet - unique elements
        HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 5 };
        uniqueNumbers.Add(3);  // Duplicate, won't be added
        uniqueNumbers.Add(6);
        Console.WriteLine($"HashSet: [{string.Join(", ", uniqueNumbers)}]");
        
        // Set operations
        var set1 = new HashSet<int> { 1, 2, 3, 4 };
        var set2 = new HashSet<int> { 3, 4, 5, 6 };
        
        var union = new HashSet<int>(set1);
        union.UnionWith(set2);
        Console.WriteLine($"Union: [{string.Join(", ", union)}]");
        
        var intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine($"Intersection: [{string.Join(", ", intersection)}]");
        
        // Queue (FIFO)
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        
        Console.WriteLine($"Queue count: {queue.Count}");
        Console.WriteLine($"Peek: {queue.Peek()}");
        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        Console.WriteLine($"Queue after dequeue: [{string.Join(", ", queue)}]");
        
        // Stack (LIFO)
        Stack<string> stack = new Stack<string>();
        stack.Push("Bottom");
        stack.Push("Middle");
        stack.Push("Top");
        
        Console.WriteLine($"Stack count: {stack.Count}");
        Console.WriteLine($"Peek: {stack.Peek()}");
        Console.WriteLine($"Pop: {stack.Pop()}");
        Console.WriteLine($"Stack after pop: [{string.Join(", ", stack)}]");
    }

    static void Exercise5_CollectionOperations()
    {
        Console.WriteLine("\n--- Exercise 5: Collection Operations ---");
        
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // LINQ preview (covered more in Day 09)
        var evens = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine($"Evens: [{string.Join(", ", evens)}]");
        
        var doubled = numbers.Select(n => n * 2).ToList();
        Console.WriteLine($"Doubled: [{string.Join(", ", doubled)}]");
        
        var sum = numbers.Sum();
        var average = numbers.Average();
        Console.WriteLine($"Sum: {sum}, Average: {average}");
        
        var max = numbers.Max();
        var min = numbers.Min();
        Console.WriteLine($"Max: {max}, Min: {min}");
        
        // Collection expressions (C# 12+)
        int[] arr = [1, 2, 3, 4, 5];
        List<int> list = [6, 7, 8, 9, 10];
        Console.WriteLine($"Array: [{string.Join(", ", arr)}]");
        Console.WriteLine($"List: [{string.Join(", ", list)}]");
        
        // Spread operator
        int[] combined = [.. arr, .. list];
        Console.WriteLine($"Combined: [{string.Join(", ", combined)}]");
    }
}

class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}
