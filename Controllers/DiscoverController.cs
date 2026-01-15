using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class DiscoverController : Controller
    {
        // We are skipping the C# backend logic because:
        // 1. We don't want to manage the "credentials.json" file on every team member's PC.
        // 2. We already built the matching algorithm using JavaScript in the View!

        public IActionResult Index()
        {
            // Just load the page. The JavaScript will fetch the data using the API Key.
            return View();
        }
    }
}