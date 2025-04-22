using Microsoft.AspNetCore.Mvc;

namespace SS.WebApp.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult NewSale()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Sale()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SaleReport()
        {
            return View();
        }

    }
}
