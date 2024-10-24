using System;
using System.Threading.Tasks;

namespace Lab2
{
    public class TaskExample
    {
        public static async Task Run()
        {
            var result = await LongRunningOperation();
            Console.WriteLine("Result of long-running operation: " + result);
        }

        private static Task<string> LongRunningOperation()
        {
            return Task.Run(() =>
            {
                Task.Delay(3000).Wait();
                return "Operation complete!";
            });
        }
    }
}
