using System;
using System.Net.Http;
using System.Threading.Tasks;

public class AsyncAwaitExample
{
    private static readonly HttpClient client = new HttpClient();

    public async Task FetchDataFromApiAsync()
    {
        Console.WriteLine("Fetching data from API...");
        string url = "https://jsonplaceholder.typicode.com/posts";
        string response = await client.GetStringAsync(url);
        Console.WriteLine($"Received data: {response.Substring(0, 100)}...");
    }

    public async Task ReadFileAsync()
    {
        string path = "data.txt";
        if (System.IO.File.Exists(path))
        {
            Console.WriteLine("Reading data from file...");
            string content = await System.IO.File.ReadAllTextAsync(path);
            Console.WriteLine($"File content: {content}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public async Task CalculateFactorialAsync(int number)
    {
        Console.WriteLine($"Calculating the factorial of {number}...");
        long result = await Task.Run(() =>
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                Task.Delay(100).Wait();
            }
            return factorial;
        });
        Console.WriteLine($"The factorial of {number} is {result}");
    }
}
