using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet("contact")] // get req for /contact

        public ViewResult Index(){
            return View();
        }

        [HttpPost("sendMessage")]
        public IActionResult SendMessage(string firstName, string lastName, string email, string message) {
            ViewBag.first = firstName;
            ViewBag.last = lastName;
            ViewBag.mail = email;
            ViewBag.msg = message;
            return View();
        }

// [HttpGet("confirm")]
//         public ViewResult Confirm() {
//             return View();
//         }
    }
}