using Newtonsoft.Json;
namespace JsonTest.Newtonsoft;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        
        //Serialize JSON
        Product product = new Product();
        product.Name = "Apple";
        product.Expiry = new DateTime(2008, 12, 28);
        product.Sizes = new string[] { "Small", "Big" };

        string jsonFromObject = JsonConvert.SerializeObject(product);
        
        //Deserialize JSON
        string jsonString = @"{
            'Name': 'Bad Boys',
            'ReleaseData': '1995-4-7T00:00:00',
            'Genres': [
                'Action',
                'Comedy'
            ]
        }";

        Movie movie = JsonConvert.DeserializeObject<Movie>(jsonString);
        string name = movie.Name;
        
        //LINQ to JSON
    }
}