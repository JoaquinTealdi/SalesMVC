using Microsoft.AspNetCore.Mvc;

namespace SS.WebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
