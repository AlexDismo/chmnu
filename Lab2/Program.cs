using System;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await FileExample.Run();
            await JsonExample.Run();
            await HttpClientExample.Run();
            await LinqExample.Run();
            await TaskExample.Run();
        }
    }
}