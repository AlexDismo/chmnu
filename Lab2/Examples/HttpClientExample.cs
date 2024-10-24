using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lab2
{
    public class HttpClientExample
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task Run()
        {
            string url = "https://api.github.com/repos/dotnet/aspnetcore";
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            string responseBody = await client.GetStringAsync(url);
            Console.WriteLine("Response from GitHub API: " + responseBody);
        }
    }
}