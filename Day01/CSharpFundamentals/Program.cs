// Day 01: C# Fundamentals
// Topics: Console I/O, Variables, Basic Operators, String Formatting

namespace CSharpFundamentals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 01: C# Fundamentals ===\n");

        // Exercise 1: Basic Console Output
        Exercise1_ConsoleOutput();

        // Exercise 2: Variables and Data Types
        Exercise2_VariablesAndDataTypes();

        // Exercise 3: Basic Operators
        Exercise3_BasicOperators();

        // Exercise 4: String Formatting
        Exercise4_StringFormatting();

        // Exercise 5: User Input
        Exercise5_UserInput();

        Console.WriteLine("\n=== Day 01 Complete! ===");
    }

    static void Exercise1_ConsoleOutput()
    {
        Console.WriteLine("\n--- Exercise 1: Console Output ---");
        
        // Single line output
        Console.WriteLine("Hello, C# World!");
        
        // Multiple outputs
        Console.Write("This is ");
        Console.Write("on the ");
        Console.WriteLine("same line.");
        
        // Special characters
        Console.WriteLine("Tab:\tSeparated");
        Console.WriteLine("New\nLine");
        Console.WriteLine("Quote: \"Hello\"");
    }

    static void Exercise2_VariablesAndDataTypes()
    {
        Console.WriteLine("\n--- Exercise 2: Variables and Data Types ---");
        
        // Integer types
        int age = 25;
        long population = 8000000000L;
        
        // Floating-point types
        double price = 19.99;
        decimal precisePrice = 19.99m;
        
        // Boolean
        bool isStudent = true;
        
        // Character and String
        char grade = 'A';
        string name = "Developer";
        
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Precise Price: ${precisePrice}");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Name: {name}");
        
        // Implicit typing with var
        var city = "Seattle";
        var yearFounded = 1851;
        Console.WriteLine($"{city} was founded in {yearFounded}");
    }

    static void Exercise3_BasicOperators()
    {
        Console.WriteLine("\n--- Exercise 3: Basic Operators ---");
        
        // Arithmetic operators
        int a = 10;
        int b = 3;
        
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        
        // Increment/Decrement
        int counter = 5;
        Console.WriteLine($"Counter: {counter}");
        Console.WriteLine($"Post-increment: {counter++}"); // Returns 5, then increments
        Console.WriteLine($"After post-increment: {counter}"); // Now 6
        Console.WriteLine($"Pre-increment: {++counter}"); // Increments, then returns 7
        
        // Comparison operators
        Console.WriteLine($"{a} > {b}: {a > b}");
        Console.WriteLine($"{a} == {b}: {a == b}");
        Console.WriteLine($"{a} != {b}: {a != b}");
        
        // Logical operators
        bool hasLicense = true;
        int driverAge = 18;
        bool canDrive = hasLicense && driverAge >= 16;
        Console.WriteLine($"Can drive: {canDrive}");
    }

    static void Exercise4_StringFormatting()
    {
        Console.WriteLine("\n--- Exercise 4: String Formatting ---");
        
        string firstName = "John";
        string lastName = "Doe";
        int age = 30;
        double salary = 75000.50;
        
        // String concatenation
        Console.WriteLine("Concatenation: " + firstName + " " + lastName);
        
        // String interpolation (modern C#)
        Console.WriteLine($"Interpolation: {firstName} {lastName}");
        Console.WriteLine($"Full info: {firstName} {lastName}, Age: {age}, Salary: ${salary:N2}");
        
        // Composite formatting
        Console.WriteLine("Composite: {0} {1} is {2} years old", firstName, lastName, age);
        
        // String methods
        string message = "  Hello World  ";
        Console.WriteLine($"Original: '{message}'");
        Console.WriteLine($"Upper: '{message.ToUpper()}'");
        Console.WriteLine($"Lower: '{message.ToLower()}'");
        Console.WriteLine($"Trimmed: '{message.Trim()}'");
        Console.WriteLine($"Contains 'World': {message.Contains("World")}");
        Console.WriteLine($"Replace: '{message.Replace("World", "C#")}'");
    }

    static void Exercise5_UserInput()
    {
        Console.WriteLine("\n--- Exercise 5: User Input ---");
        
        Console.Write("Enter your name: ");
        string? userName = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        string? ageInput = Console.ReadLine();
        
        // Parse string to int
        if (int.TryParse(ageInput, out int userAge))
        {
            Console.WriteLine($"\nHello, {userName}!");
            Console.WriteLine($"In 5 years, you will be {userAge + 5} years old.");
        }
        else
        {
            Console.WriteLine("Invalid age entered.");
        }
    }
}
