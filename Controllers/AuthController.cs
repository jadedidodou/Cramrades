using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class AuthController : Controller
    {
        // GET: /Auth/SignUp
        public IActionResult SignUp() { 
            return View(); 
        }

        // GET: /Auth/Login
        public IActionResult Login() { 
            return View(); 
        }

        // GET: /Auth/ProfileSetup
        // This just shows the page
        public IActionResult ProfileSetup()
        {
            return View();
        }

        // POST: /Auth/ProfileSetup
        // ADD THIS: This handles the "Finish" button click
        [HttpPost]
        public IActionResult ProfileSetup(IFormCollection form)
        {
            // For now, we are just skipping the database save 
            // to ensure the redirect works.
            
            // This line sends the user to the Discover page
            return RedirectToAction("Index", "Discover");
        }

        // Destination after registration is finished
        public IActionResult CompleteRegistration()
        {
            return RedirectToAction("Index", "Discover");
        }
    }
}