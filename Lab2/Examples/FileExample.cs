using System;
using System.IO;
using System.Threading.Tasks;

namespace Lab2
{
    public class FileExample
    {
        public static async Task Run()
        {
            string path = "example.txt";
            await File.WriteAllTextAsync(path, "Hello, world!");
            string content = await File.ReadAllTextAsync(path);
            Console.WriteLine("File content: " + content);
            File.Delete(path);
            Console.WriteLine("File deleted.");
        }
    }
}
