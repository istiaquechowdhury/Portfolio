using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
