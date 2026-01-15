using Microsoft.AspNetCore.Mvc;
using System;

namespace cramrades.Controllers
{
    public class HomeController : Controller
    {
        // 1. THE DASHBOARD (Your new Home Page)
        public IActionResult Index()
        {
            return View();
        }

        // 2. THE CHAT PAGE (For the Messages)
        public IActionResult Messages()
        {
            return View("~/Views/Messages/Index.cshtml");
        }

        // 3. THE FEED (Redirects to Dashboard now)
        public IActionResult Feed()
        {
            return RedirectToAction("Index");
        }

    }
}