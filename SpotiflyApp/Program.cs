using SpotiflyApp.Model;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
namespace SpotiflyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist artist1 = new Artist()
            {
                Birthday = new DateOnly(2001, 1, 5),
                Id = "1",
                Name = "Henri Millet",
                Country = "France"
            };
            Artist artist2 = new Artist()
            {
                Birthday = new DateOnly(1985, 10, 15),
                Id = "2",
                Name = "Benjamin Hav",
                Country = "Denmark"
            };
            var artist3 = new Artist()
            {
                Birthday = new DateOnly(1975, 12, 24),
                Id = "3",
                Name = "Christian Noel",
                Country = "Belgium"
            };

            Console.WriteLine($"Name: {artist1.Name}, Country: {artist1.Country}, Birthday: {artist1.Birthday}, Age: {artist1.Age}");
        }
    }
}
