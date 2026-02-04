// Day 14: Final Certification Project - Task Manager
// A comprehensive console application demonstrating all learned C# concepts

/*
 * PROJECT REQUIREMENTS:
 * 1. OOP Design: Classes, Inheritance, Interfaces
 * 2. Modern C#: LINQ, Records, Pattern Matching
 * 3. File I/O: JSON Serialization
 * 4. Error Handling: Try-Catch, Custom Exceptions
 * 5. Collections: Lists, Dictionaries
 * 
 * TODO: Complete the implementation below
 */

using System.Text.Json;

namespace TaskManager;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Task Manager - Final Certification Project ===\n");
        Console.WriteLine("This is a starter template for your certification project.");
        Console.WriteLine("Complete the implementation to demonstrate your C# mastery!\n");

        // Example task manager structure
        var manager = new TaskManager();
        
        // Add some sample tasks
        manager.AddTask(new Task("Learn C# Fundamentals", "Study Day 01-05", Priority.High));
        manager.AddTask(new Task("Master OOP", "Study Day 06-08", Priority.High));
        manager.AddTask(new Task("Learn LINQ", "Study Day 09", Priority.Medium));
        
        // Display tasks
        manager.DisplayAllTasks();
        
        // TODO: Implement more features:
        // - Save/Load tasks from JSON file
        // - Update task status
        // - Delete tasks
        // - Filter tasks by priority or status
        // - Search tasks
        // - Sort tasks
        // - Task categories
        // - Due dates
        // - And more!

        Console.WriteLine("\n=== Project Template Ready! ===");
        Console.WriteLine("Complete the implementation to earn your certification!");
    }
}

// Task class - expand with more properties and methods
class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }

    public Task(string title, string description, Priority priority)
    {
        Title = title;
        Description = description;
        Priority = priority;
        Status = TaskStatus.NotStarted;
        CreatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{Status}] {Title} - {Description} (Priority: {Priority})";
    }
}

enum Priority
{
    Low,
    Medium,
    High,
    Critical
}

enum TaskStatus
{
    NotStarted,
    InProgress,
    Completed,
    Cancelled
}

// Task Manager class - implement full CRUD operations
class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine($"Added: {task.Title}");
    }

    public void DisplayAllTasks()
    {
        Console.WriteLine("\n=== All Tasks ===");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    // TODO: Implement these methods
    // public void SaveToFile(string filePath) { }
    // public void LoadFromFile(string filePath) { }
    // public void UpdateTask(string title, TaskStatus status) { }
    // public void DeleteTask(string title) { }
    // public List<Task> FilterByPriority(Priority priority) { }
    // public List<Task> SearchTasks(string keyword) { }
}
