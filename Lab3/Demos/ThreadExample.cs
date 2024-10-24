using System;
using System.Threading;

public class ThreadExample
{
    public void SimulateImageLoading()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Loading...");
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"El {i} loaded.");
            }
        });
        thread.Start();
    }

    public void GenerateFibonacci()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Fibonacci generation...");
            int a = 0,
                b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
                Thread.Sleep(500);
            }
        });
        thread.Start();
    }

    public void CountToTen()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Count from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
        });
        thread.Start();
    }
}
