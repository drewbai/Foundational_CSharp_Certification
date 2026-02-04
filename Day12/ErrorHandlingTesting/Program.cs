// Day 12: Error Handling and Testing
// Topics: Exception Handling, try-catch-finally, Custom Exceptions

namespace ErrorHandlingTesting;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 12: Error Handling and Testing ===\n");

        // Basic exception handling
        try
        {
            int result = Divide(10, 2);
            Console.WriteLine($"10 / 2 = {result}");

            result = Divide(10, 0);  // This will throw
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Multiple catch blocks
        try
        {
            ProcessAge(-5);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Custom exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General error: {ex.Message}");
        }

        // Finally block
        try
        {
            Console.WriteLine("\nTrying operation...");
            throw new Exception("Test exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block always executes");
        }

        Console.WriteLine("\n=== Day 12 Complete! ===");
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");
        return a / b;
    }

    static void ProcessAge(int age)
    {
        if (age < 0)
            throw new InvalidAgeException("Age cannot be negative");
        Console.WriteLine($"Age: {age}");
    }
}

// Custom exception
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
