using Microsoft.AspNetCore.Mvc;

namespace cramrades.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Index() { 
            return View(); 
        }
    }
}
