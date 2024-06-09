using Microsoft.AspNetCore.Mvc;

namespace Istiaque.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
