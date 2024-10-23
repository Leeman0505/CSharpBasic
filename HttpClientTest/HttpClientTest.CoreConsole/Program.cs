using Newtonsoft.Json;
using System.Text;

namespace HttpClientTest.CoreConsole;

class Program
{
    static void Main(string[] args) 
    {
        //Console.WriteLine("Hello, World!");
        using (var client = new HttpClient())
        {
            var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
            // var result = client.GetAsync(endpoint).Result;
           // var json = result.Content.ReadAsStringAsync().Result;'
           var newPost = new Post()
           {
               Title = "Test Post",
               Body = "Hello world",
               UserId = 44
           };
           var newPostJson = JsonConvert.SerializeObject(newPost);
           var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
           var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
           Console.WriteLine(result);
        }
    }
}