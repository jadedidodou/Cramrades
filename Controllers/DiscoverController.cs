using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class DiscoverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
