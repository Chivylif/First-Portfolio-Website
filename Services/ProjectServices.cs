using MyPortfolioWebsite.Data;
using MyPortfolioWebsite.Models;

namespace MyPortfolioWebsite.Services
{
    public class ProjectServices : IProjectServices
    {
        public List<Projects> AllProjects { get; set; }

        private readonly IConfiguration _config;

        public ProjectServices(IConfiguration configure)
        {
            AllProjects = Seeder.ReadMe(configure);
            _config = configure;
        }
    }
}
