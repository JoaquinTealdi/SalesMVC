using Microsoft.AspNetCore.Mvc;

namespace SS.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
