// Day 03: Control Flow
// Topics: Conditional Statements, Loops, Pattern Matching

namespace ControlFlow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 03: Control Flow ===\n");

        Exercise1_IfElseStatements();
        Exercise2_SwitchStatements();
        Exercise3_ForLoops();
        Exercise4_WhileLoops();
        Exercise5_PatternMatching();

        Console.WriteLine("\n=== Day 03 Complete! ===");
    }

    static void Exercise1_IfElseStatements()
    {
        Console.WriteLine("\n--- Exercise 1: If-Else Statements ---");
        
        int temperature = 75;
        
        // Simple if
        if (temperature > 80)
        {
            Console.WriteLine("It's hot outside!");
        }
        
        // If-else
        if (temperature < 32)
        {
            Console.WriteLine("It's freezing!");
        }
        else
        {
            Console.WriteLine($"Temperature is {temperature}°F");
        }
        
        // If-else if-else
        if (temperature >= 90)
        {
            Console.WriteLine("Extreme heat");
        }
        else if (temperature >= 75)
        {
            Console.WriteLine("Warm weather");
        }
        else if (temperature >= 60)
        {
            Console.WriteLine("Mild weather");
        }
        else if (temperature >= 32)
        {
            Console.WriteLine("Cold weather");
        }
        else
        {
            Console.WriteLine("Freezing weather");
        }
        
        // Ternary operator
        string weather = temperature > 70 ? "warm" : "cool";
        Console.WriteLine($"It's {weather} today");
        
        // Logical operators
        int hour = 14;
        bool isWeekend = false;
        
        if (hour >= 9 && hour <= 17 && !isWeekend)
        {
            Console.WriteLine("Business hours on weekday");
        }
        
        // Null-conditional operator
        string? name = "Alice";
        int? length = name?.Length;
        Console.WriteLine($"Name length: {length ?? 0}");
    }

    static void Exercise2_SwitchStatements()
    {
        Console.WriteLine("\n--- Exercise 2: Switch Statements ---");
        
        // Traditional switch
        int dayNumber = 3;
        string dayName;
        
        switch (dayNumber)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
            case 7:
                dayName = "Weekend";
                break;
            default:
                dayName = "Invalid day";
                break;
        }
        Console.WriteLine($"Day {dayNumber}: {dayName}");
        
        // Switch expression (C# 8+)
        string season = 6 switch
        {
            12 or 1 or 2 => "Winter",
            >= 3 and <= 5 => "Spring",
            >= 6 and <= 8 => "Summer",
            >= 9 and <= 11 => "Fall",
            _ => "Unknown"
        };
        Console.WriteLine($"Month 6 is in: {season}");
        
        // Switch with when clause
        int score = 85;
        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
        Console.WriteLine($"Score {score} = Grade {grade}");
    }

    static void Exercise3_ForLoops()
    {
        Console.WriteLine("\n--- Exercise 3: For Loops ---");
        
        // Basic for loop
        Console.Write("Count to 5: ");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        // Countdown
        Console.Write("Countdown: ");
        for (int i = 5; i >= 1; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        // Skip evens
        Console.Write("Odds only: ");
        for (int i = 1; i <= 10; i += 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        // Foreach with array
        string[] fruits = { "Apple", "Banana", "Cherry" };
        Console.Write("Fruits: ");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
        Console.WriteLine();
        
        // Foreach with range
        Console.Write("Range 0-4: ");
        foreach (int num in Enumerable.Range(0, 5))
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        // Break and continue
        Console.Write("Break at 5: ");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) break;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        Console.Write("Skip 3: ");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) continue;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        // Nested loops
        Console.WriteLine("Multiplication table (3x3):");
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"{i * j,3} ");
            }
            Console.WriteLine();
        }
    }

    static void Exercise4_WhileLoops()
    {
        Console.WriteLine("\n--- Exercise 4: While Loops ---");
        
        // While loop
        int count = 1;
        Console.Write("While loop: ");
        while (count <= 5)
        {
            Console.Write($"{count} ");
            count++;
        }
        Console.WriteLine();
        
        // Do-while loop (executes at least once)
        int number = 10;
        Console.Write("Do-while: ");
        do
        {
            Console.Write($"{number} ");
            number++;
        } while (number <= 5);  // Condition false, but executes once
        Console.WriteLine();
        
        // While with break
        int attempts = 0;
        Console.Write("While with break: ");
        while (true)
        {
            attempts++;
            Console.Write($"{attempts} ");
            if (attempts >= 3) break;
        }
        Console.WriteLine();
        
        // Simulating input validation
        Console.WriteLine("\nInput validation simulation:");
        int userAttempts = 0;
        bool validInput = false;
        
        while (!validInput && userAttempts < 3)
        {
            userAttempts++;
            // Simulate checking input
            bool inputIsValid = userAttempts == 2;  // Pretend 2nd attempt is valid
            
            if (inputIsValid)
            {
                Console.WriteLine($"Attempt {userAttempts}: Valid input!");
                validInput = true;
            }
            else
            {
                Console.WriteLine($"Attempt {userAttempts}: Invalid, try again");
            }
        }
    }

    static void Exercise5_PatternMatching()
    {
        Console.WriteLine("\n--- Exercise 5: Pattern Matching (Modern C#) ---");
        
        // Type patterns
        object obj = "Hello";
        if (obj is string str)
        {
            Console.WriteLine($"String with length: {str.Length}");
        }
        
        // Property patterns
        var point = new Point { X = 0, Y = 0 };
        string location = point switch
        {
            { X: 0, Y: 0 } => "Origin",
            { X: 0 } => "Y-axis",
            { Y: 0 } => "X-axis",
            { X: var x, Y: var y } when x == y => "Diagonal",
            _ => "Somewhere else"
        };
        Console.WriteLine($"Point ({point.X}, {point.Y}): {location}");
        
        // Relational patterns
        int age = 25;
        string category = age switch
        {
            < 13 => "Child",
            >= 13 and < 20 => "Teenager",
            >= 20 and < 65 => "Adult",
            _ => "Senior"
        };
        Console.WriteLine($"Age {age}: {category}");
        
        // List patterns (C# 11+)
        int[] numbers = { 1, 2, 3, 4, 5 };
        string pattern = numbers switch
        {
            [] => "Empty",
            [var single] => $"Single: {single}",
            [var first, .., var last] => $"First: {first}, Last: {last}",
            _ => "Other"
        };
        Console.WriteLine($"Array pattern: {pattern}");
        
        // Null checking with patterns
        string? nullableString = null;
        if (nullableString is not null)
        {
            Console.WriteLine($"Has value: {nullableString}");
        }
        else
        {
            Console.WriteLine("String is null");
        }
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
