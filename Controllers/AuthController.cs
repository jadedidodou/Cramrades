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
    }
}
