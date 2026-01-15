using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignUp() { 
            return View(); 
        }

        public IActionResult Login() { 
            return View(); 
        }

        public IActionResult ProfileSetup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProfileSetup(IFormCollection form)
        {       
            return RedirectToAction("Index", "Discover");
        }

        // Destination after registration is finished
        public IActionResult CompleteRegistration()
        {
            return RedirectToAction("Index", "Discover");
        }

        public IActionResult ProfileEdit() 
        { 
            return View(); 
        }
    }
}