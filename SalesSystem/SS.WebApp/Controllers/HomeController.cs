using Microsoft.AspNetCore.Mvc;
using SS.DAL;
using SS.Model.Models;
using SS.WebApp.Models;
using System.Diagnostics;

namespace SS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly testt testt;
        public HomeController(ILogger<HomeController> logger, testt testt)
        {
            _logger = logger;
            this.testt = testt;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }
        public IActionResult Profile()
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
