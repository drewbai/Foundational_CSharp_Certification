// Day 10: Async/Await and Tasks
// Topics: Asynchronous Programming, Task, async/await

namespace AsyncAwait;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Day 10: Async/Await and Tasks ===\n");

        Console.WriteLine("Starting async operations...");

        // Single async operation
        await DownloadDataAsync("https://api.example.com/data1");

        // Multiple async operations in sequence
        await DownloadDataAsync("https://api.example.com/data2");

        // Multiple async operations in parallel
        var task1 = DownloadDataAsync("https://api.example.com/data3");
        var task2 = DownloadDataAsync("https://api.example.com/data4");
        await Task.WhenAll(task1, task2);

        Console.WriteLine("\nAll operations complete!");
        Console.WriteLine("\n=== Day 10 Complete! ===");
    }

    static async Task DownloadDataAsync(string url)
    {
        Console.WriteLine($"Downloading from {url}...");
        await Task.Delay(1000);  // Simulate async work
        Console.WriteLine($"Downloaded from {url}");
    }
}
