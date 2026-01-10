using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Feed()
        {
            return View();
        }
        public IActionResult Seeder()
        {
            return View();
        }
    }
}
