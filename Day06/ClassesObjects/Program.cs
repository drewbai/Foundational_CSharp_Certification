// Day 06: Classes and Objects
// Topics: Class Definition, Properties, Constructors, Object Initialization

namespace ClassesObjects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Day 06: Classes and Objects ===\n");

        // Creating objects
        var person1 = new Person();
        person1.FirstName = "Alice";
        person1.LastName = "Smith";
        person1.Age = 30;
        person1.Introduce();

        // Constructor with parameters
        var person2 = new Person("Bob", "Jones", 25);
        person2.Introduce();
        Console.WriteLine($"Full name: {person2.FullName}");

        // Object initializer
        var person3 = new Person
        {
            FirstName = "Charlie",
            LastName = "Brown",
            Age = 35
        };
        person3.Introduce();

        // Working with a more complex class
        var account = new BankAccount("12345", 1000m);
        account.DisplayBalance();
        account.Deposit(500m);
        account.Withdraw(200m);
        account.DisplayBalance();

        // Static members
        Console.WriteLine($"\nTotal accounts created: {BankAccount.TotalAccounts}");

        Console.WriteLine("\n=== Day 06 Complete! ===");
    }
}

class Person
{
    // Auto-implemented properties
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }

    // Computed property
    public string FullName => $"{FirstName} {LastName}";

    // Default constructor
    public Person()
    {
    }

    // Parameterized constructor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {FullName} and I'm {Age} years old.");
    }
}

class BankAccount
{
    // Static field
    public static int TotalAccounts { get; private set; }

    // Properties
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }

    // Constructor
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        TotalAccounts++;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account {AccountNumber}: ${Balance}");
    }
}
