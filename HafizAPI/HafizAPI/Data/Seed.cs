using System.IO;
using System.Threading.Tasks;
using HafizApi.Data;
using HafizApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HafizApi
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.Surahs.Any())
            {
                // Get the relative path to the JSON file
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "surah.json");

                // Load and deserialize JSON data
                var surahData = File.ReadAllText("./surah.json");
                var surahs = JsonConvert.DeserializeObject<List<SurahJson>>(surahData);

                foreach (var surahJson in surahs)
                {
                    // Create a new Surah object from the JSON data
                    var newSurah = new Surah
                    {
                        // Remove SurahID assignment to allow the database to handle it
                        SurahName = surahJson.title,
                        NumberOfAyat = surahJson.count,
                        Ayahs = new List<Ayah>() // You can seed Ayahs if needed
                    };

                    context.Surahs.Add(newSurah);
                }

                // Save changes to the database
                await context.SaveChangesAsync();
            }
        }
    }

    // Define a class to map the JSON structure
    public class SurahJson
    {
        public string index { get; set; }
        public string title { get; set; }
        public int count { get; set; }
    }
}
