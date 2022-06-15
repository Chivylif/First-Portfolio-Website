using Microsoft.AspNetCore.Mvc;
using MyPortfolioWebsite.Models;
using MyPortfolioWebsite.Services;
using MyPortfolioWebsite.ViewModels;
using System.Diagnostics;

namespace MyPortfolioWebsite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IProjectServices _projectServices;
        public HomeController(IProjectServices projectServices)
        {
            _projectServices = projectServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Project()
        {
            var ProjectList = new List<ProjectViewModel>();
            var projects = _projectServices.AllProjects;
            foreach (var project in projects)
            {
                ProjectList.Add(new ProjectViewModel()
                {
                    Title = project.Title,
                    Body = project.Body
                });
            }

            return View(ProjectList);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}