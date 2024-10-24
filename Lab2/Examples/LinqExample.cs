using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class LinqExample
    {
        public static async Task Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        }
    }
}
