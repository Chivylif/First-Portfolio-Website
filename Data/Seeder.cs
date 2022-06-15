using MyPortfolioWebsite.Models;
using Newtonsoft.Json;

namespace MyPortfolioWebsite.Data
{
    public class Seeder
    {
        public static List<Projects> ReadMe(IConfiguration configure)
        {
            var project = File.ReadAllText(configure.GetSection("FilePath:Path").Value);

            var projects = JsonConvert.DeserializeObject<List<Projects>>(project);

            return projects;
        }
    }
}
