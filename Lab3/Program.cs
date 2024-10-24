using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        ThreadExample threadDemo = new ThreadExample();
        threadDemo.SimulateImageLoading();
        threadDemo.GenerateFibonacci();
        threadDemo.CountToTen();

        Thread.Sleep(5000);

        Console.WriteLine("==== Async Methods ====");
        AsyncAwaitExample asyncDemo = new AsyncAwaitExample();
        await asyncDemo.FetchDataFromApiAsync();
        await asyncDemo.ReadFileAsync();
        await asyncDemo.CalculateFactorialAsync(5);
    }
}
