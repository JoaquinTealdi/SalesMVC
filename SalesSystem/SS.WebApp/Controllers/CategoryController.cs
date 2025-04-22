using Microsoft.AspNetCore.Mvc;

namespace SS.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
