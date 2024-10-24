using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2
{
    public class JsonExample
    {
        public static async Task Run()
        {
            var model = new JsonExampleModel { Title = "Test Title", Body = "This is the body." };
            string jsonString = JsonSerializer.Serialize(model);
            await File.WriteAllTextAsync("model.json", jsonString);
            Console.WriteLine("JSON written to file.");
            string jsonFromFile = await File.ReadAllTextAsync("model.json");
            var deserializedModel = JsonSerializer.Deserialize<JsonExampleModel>(jsonFromFile);
            Console.WriteLine("Deserialized JSON: " + deserializedModel.Title);
        }
    }

    public class JsonExampleModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
