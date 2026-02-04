// Day 05: Methods and Parameters
// Topics: Method Declaration, Parameters (ref, out, in, params), Expression-bodied Members

namespace MethodsParameters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 05: Methods and Parameters ===\n");

        Exercise1_BasicMethods();
        Exercise2_ParameterModifiers();
        Exercise3_OptionalAndNamedParameters();
        Exercise4_ExpressionBodiedMembers();
        Exercise5_LocalFunctions();

        Console.WriteLine("\n=== Day 05 Complete! ===");
    }

    static void Exercise1_BasicMethods()
    {
        Console.WriteLine("\n--- Exercise 1: Basic Methods ---");
        
        // Method with no parameters, no return
        PrintHeader();
        
        // Method with parameters, no return
        Greet("Alice");
        
        // Method with return value
        int sum = Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");
        
        // Method with multiple parameters
        int result = Calculate(10, 5, "multiply");
        Console.WriteLine($"10 * 5 = {result}");
        
        // Method returning complex type
        Person person = CreatePerson("Bob", 30);
        Console.WriteLine($"Created: {person.Name}, {person.Age}");
        
        // Method overloading
        Console.WriteLine($"Area of square (5): {CalculateArea(5)}");
        Console.WriteLine($"Area of rectangle (5, 3): {CalculateArea(5, 3)}");
        Console.WriteLine($"Area of circle (5): {CalculateArea(5.0)}");
    }

    static void PrintHeader()
    {
        Console.WriteLine("=== Welcome ===");
    }

    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Calculate(int a, int b, string operation)
    {
        return operation switch
        {
            "add" => a + b,
            "subtract" => a - b,
            "multiply" => a * b,
            "divide" when b != 0 => a / b,
            _ => 0
        };
    }

    static Person CreatePerson(string name, int age)
    {
        return new Person { Name = name, Age = age };
    }

    // Method overloading
    static int CalculateArea(int side) => side * side;
    static int CalculateArea(int length, int width) => length * width;
    static double CalculateArea(double radius) => Math.PI * radius * radius;

    static void Exercise2_ParameterModifiers()
    {
        Console.WriteLine("\n--- Exercise 2: Parameter Modifiers ---");
        
        // ref - passing by reference (must be initialized)
        int value = 10;
        Console.WriteLine($"Before ref: {value}");
        Increment(ref value);
        Console.WriteLine($"After ref: {value}");
        
        // out - output parameter (doesn't need initialization)
        int quotient, remainder;
        Divide(17, 5, out quotient, out remainder);
        Console.WriteLine($"17 / 5 = {quotient} remainder {remainder}");
        
        // Inline out declaration
        Divide(20, 3, out int q, out int r);
        Console.WriteLine($"20 / 3 = {q} remainder {r}");
        
        // in - read-only reference (prevents copying for large structs)
        LargeStruct large = new LargeStruct { Data = new int[100] };
        ProcessLargeStruct(in large);
        
        // params - variable number of parameters
        int sum = Sum(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of 1,2,3,4,5: {sum}");
        
        int[] numbers = { 10, 20, 30 };
        int arraySum = Sum(numbers);
        Console.WriteLine($"Sum of array: {arraySum}");
    }

    static void Increment(ref int number)
    {
        number++;
    }

    static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }

    static void ProcessLargeStruct(in LargeStruct data)
    {
        Console.WriteLine($"Processing large struct with {data.Data.Length} elements");
    }

    static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    static void Exercise3_OptionalAndNamedParameters()
    {
        Console.WriteLine("\n--- Exercise 3: Optional and Named Parameters ---");
        
        // Optional parameters with defaults
        CreateAccount("Alice");
        CreateAccount("Bob", "Premium");
        CreateAccount("Charlie", "Basic", true);
        
        // Named parameters
        CreateAccount(username: "David", isActive: true, accountType: "Gold");
        
        // Mix positional and named
        CreateAccount("Eve", isActive: false);
        
        // Optional with null defaults
        SendEmail("user@example.com", "Hello", null);
    }

    static void CreateAccount(string username, string accountType = "Standard", bool isActive = true)
    {
        Console.WriteLine($"Account: {username}, Type: {accountType}, Active: {isActive}");
    }

    static void SendEmail(string to, string subject, string? body = null)
    {
        Console.WriteLine($"Email to {to}: {subject}");
        if (body != null)
        {
            Console.WriteLine($"Body: {body}");
        }
    }

    static void Exercise4_ExpressionBodiedMembers()
    {
        Console.WriteLine("\n--- Exercise 4: Expression-bodied Members ---");
        
        // Expression-bodied methods (already shown above)
        Console.WriteLine($"Square of 7: {Square(7)}");
        Console.WriteLine($"IsEven(8): {IsEven(8)}");
        Console.WriteLine($"GetFullName: {GetFullName("John", "Doe")}");
        
        // Expression-bodied properties
        var calc = new Calculator();
        Console.WriteLine($"PI constant: {calc.PI}");
        
        // Expression-bodied constructors
        var item = new Item("Widget", 9.99m);
        Console.WriteLine($"Item: {item.Name} - ${item.Price}");
    }

    static int Square(int x) => x * x;
    static bool IsEven(int x) => x % 2 == 0;
    static string GetFullName(string first, string last) => $"{first} {last}";

    static void Exercise5_LocalFunctions()
    {
        Console.WriteLine("\n--- Exercise 5: Local Functions ---");
        
        // Local function within a method
        int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
        
        Console.WriteLine($"Factorial of 5: {Factorial(5)}");
        
        // Local function with closure
        int multiplier = 3;
        int Multiply(int x) => x * multiplier;
        
        Console.WriteLine($"10 * {multiplier}: {Multiply(10)}");
        
        // Static local function (can't capture variables)
        static int AddNumbers(int a, int b) => a + b;
        Console.WriteLine($"Static local: 15 + 25 = {AddNumbers(15, 25)}");
        
        // Multiple local functions
        ProcessNumbers();
    }

    static void ProcessNumbers()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        bool IsEven(int n) => n % 2 == 0;
        bool IsOdd(int n) => n % 2 != 0;
        void PrintList(string label, IEnumerable<int> items)
        {
            Console.WriteLine($"{label}: [{string.Join(", ", items)}]");
        }
        
        PrintList("All numbers", numbers);
        PrintList("Even numbers", numbers.Where(IsEven));
        PrintList("Odd numbers", numbers.Where(IsOdd));
    }
}

class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

struct LargeStruct
{
    public int[] Data { get; set; }
}

class Calculator
{
    public double PI => 3.14159265359;
}

class Item
{
    public string Name { get; }
    public decimal Price { get; }
    
    // Expression-bodied constructor
    public Item(string name, decimal price) => (Name, Price) = (name, price);
}
