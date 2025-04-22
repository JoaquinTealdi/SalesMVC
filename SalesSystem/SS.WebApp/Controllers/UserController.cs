using Microsoft.AspNetCore.Mvc;

namespace SS.WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
