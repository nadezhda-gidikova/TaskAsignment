
namespace Task1
{
    using Newtonsoft.Json;
    using Tasks_1;

    public class StartUp
    {
        static void Main(string[] args)
        {
            MovieStar moviestar = new MovieStar();
            string jsonString = File.ReadAllText("../../../input.txt");
            var jsonObject = JsonConvert.DeserializeObject<List<MovieStar>>(jsonString);

            foreach (var item in jsonObject)
            {
                Console.WriteLine(item);
            }
        }
    }
}