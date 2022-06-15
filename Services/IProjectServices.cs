using MyPortfolioWebsite.Models;

namespace MyPortfolioWebsite.Services
{
    public interface IProjectServices
    {
        List<Projects> AllProjects { get; set; }
    }
}
