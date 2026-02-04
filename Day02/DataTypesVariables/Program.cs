// Day 02: Data Types and Variables
// Topics: Value vs Reference Types, Type Conversion, String Manipulation

namespace DataTypesVariables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 02: Data Types and Variables ===\n");

        Exercise1_ValueTypes();
        Exercise2_ReferenceTypes();
        Exercise3_TypeConversion();
        Exercise4_StringManipulation();
        Exercise5_Constants();

        Console.WriteLine("\n=== Day 02 Complete! ===");
    }

    static void Exercise1_ValueTypes()
    {
        Console.WriteLine("\n--- Exercise 1: Value Types ---");
        
        // Numeric types with different sizes
        byte byteValue = 255;              // 0 to 255
        short shortValue = 32000;          // -32,768 to 32,767
        int intValue = 2147483647;         // -2.1B to 2.1B
        long longValue = 9223372036854775807L;
        
        // Floating-point precision
        float floatValue = 3.14159f;       // ~7 digits precision
        double doubleValue = 3.14159265359; // ~15 digits precision
        decimal decimalValue = 19.99m;      // 28-29 digits (for money)
        
        // Other value types
        bool isActive = true;
        char initial = 'D';
        
        Console.WriteLine($"byte: {byteValue} (size: {sizeof(byte)} bytes)");
        Console.WriteLine($"short: {shortValue} (size: {sizeof(short)} bytes)");
        Console.WriteLine($"int: {intValue} (size: {sizeof(int)} bytes)");
        Console.WriteLine($"long: {longValue} (size: {sizeof(long)} bytes)");
        Console.WriteLine($"float: {floatValue} (size: {sizeof(float)} bytes)");
        Console.WriteLine($"double: {doubleValue} (size: {sizeof(double)} bytes)");
        Console.WriteLine($"decimal: {decimalValue} (size: {sizeof(decimal)} bytes)");
        Console.WriteLine($"bool: {isActive} (size: {sizeof(bool)} byte)");
        Console.WriteLine($"char: {initial} (size: {sizeof(char)} bytes)");
        
        // Value type behavior - copied on assignment
        int original = 10;
        int copy = original;
        copy = 20;
        Console.WriteLine($"\nValue type copy: original={original}, copy={copy}");
    }

    static void Exercise2_ReferenceTypes()
    {
        Console.WriteLine("\n--- Exercise 2: Reference Types ---");
        
        // Strings are reference types
        string message = "Hello";
        string alias = message;
        alias = "World";  // Strings are immutable, creates new object
        Console.WriteLine($"String: message={message}, alias={alias}");
        
        // Arrays are reference types
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1;  // Both point to same array
        array2[0] = 99;
        Console.WriteLine($"Array reference: array1[0]={array1[0]}, array2[0]={array2[0]}");
        
        // Nullable value types
        int? nullableInt = null;
        Console.WriteLine($"Nullable int: {nullableInt ?? -1} (using null-coalescing)");
        
        nullableInt = 42;
        Console.WriteLine($"Nullable int with value: {nullableInt}");
        Console.WriteLine($"Has value: {nullableInt.HasValue}");
        Console.WriteLine($"Value: {nullableInt.Value}");
    }

    static void Exercise3_TypeConversion()
    {
        Console.WriteLine("\n--- Exercise 3: Type Conversion ---");
        
        // Implicit conversion (safe, no data loss)
        int intNum = 100;
        long longNum = intNum;  // int to long
        double doubleNum = intNum;  // int to double
        Console.WriteLine($"Implicit: int {intNum} -> long {longNum} -> double {doubleNum}");
        
        // Explicit conversion (casting - possible data loss)
        double pi = 3.14159;
        int truncatedPi = (int)pi;  // Truncates decimal
        Console.WriteLine($"Explicit: double {pi} -> int {truncatedPi}");
        
        // Parse methods
        string numberString = "12345";
        int parsedInt = int.Parse(numberString);
        Console.WriteLine($"Parse: '{numberString}' -> {parsedInt}");
        
        // TryParse (safe parsing)
        string invalidString = "abc";
        if (int.TryParse(invalidString, out int result))
        {
            Console.WriteLine($"Parsed: {result}");
        }
        else
        {
            Console.WriteLine($"TryParse failed for: '{invalidString}'");
        }
        
        // Convert class
        string boolString = "true";
        bool convertedBool = Convert.ToBoolean(boolString);
        Console.WriteLine($"Convert: '{boolString}' -> {convertedBool}");
        
        // ToString for any type
        int age = 25;
        string ageString = age.ToString();
        Console.WriteLine($"ToString: {age} -> '{ageString}'");
    }

    static void Exercise4_StringManipulation()
    {
        Console.WriteLine("\n--- Exercise 4: String Manipulation ---");
        
        string text = "  C# Programming  ";
        
        // String methods
        Console.WriteLine($"Original: '{text}'");
        Console.WriteLine($"Length: {text.Length}");
        Console.WriteLine($"Trim: '{text.Trim()}'");
        Console.WriteLine($"ToUpper: '{text.ToUpper()}'");
        Console.WriteLine($"ToLower: '{text.ToLower()}'");
        Console.WriteLine($"Contains 'C#': {text.Contains("C#")}");
        Console.WriteLine($"StartsWith '  C#': {text.StartsWith("  C#")}");
        Console.WriteLine($"EndsWith 'ing  ': {text.EndsWith("ing  ")}");
        
        // Substring
        string language = "C# Programming";
        Console.WriteLine($"Substring(0, 2): '{language.Substring(0, 2)}'");
        Console.WriteLine($"Substring(3): '{language.Substring(3)}'");
        
        // IndexOf and Replace
        int index = language.IndexOf("Programming");
        Console.WriteLine($"IndexOf 'Programming': {index}");
        Console.WriteLine($"Replace: '{language.Replace("Programming", "Development")}'");
        
        // Split and Join
        string sentence = "Learn,C#,Today";
        string[] words = sentence.Split(',');
        Console.WriteLine($"Split: [{string.Join(", ", words)}]");
        string joined = string.Join(" ", words);
        Console.WriteLine($"Join: '{joined}'");
        
        // String Builder for efficient concatenation
        var sb = new System.Text.StringBuilder();
        for (int i = 1; i <= 5; i++)
        {
            sb.Append($"Item{i} ");
        }
        Console.WriteLine($"StringBuilder: '{sb.ToString().Trim()}'");
        
        // String formatting
        string name = "Alice";
        int score = 95;
        Console.WriteLine($"Format: {name} scored {score:D3}%");  // D3 = 3 digit integer
        Console.WriteLine($"Format: ${score:C}");  // C = Currency
    }

    static void Exercise5_Constants()
    {
        Console.WriteLine("\n--- Exercise 5: Constants and Readonly ---");
        
        // Constants - compile-time constant
        const double PI = 3.14159;
        const string APP_NAME = "MyApp";
        
        Console.WriteLine($"Constant PI: {PI}");
        Console.WriteLine($"Constant APP_NAME: {APP_NAME}");
        
        // Readonly field (can be set in constructor)
        var demo = new ConstDemo();
        demo.ShowValues();
        
        // Using default values
        int defaultInt = default;
        string defaultString = default!;
        bool defaultBool = default;
        Console.WriteLine($"Defaults: int={defaultInt}, string={(defaultString == null ? "null" : defaultString)}, bool={defaultBool}");
    }
}

class ConstDemo
{
    public readonly int MaxAttempts;
    public const int MinAttempts = 1;
    
    public ConstDemo()
    {
        MaxAttempts = 3;  // Can be set in constructor
    }
    
    public void ShowValues()
    {
        Console.WriteLine($"Readonly MaxAttempts: {MaxAttempts}");
        Console.WriteLine($"Const MinAttempts: {MinAttempts}");
    }
}
