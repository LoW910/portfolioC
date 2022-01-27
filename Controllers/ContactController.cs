using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("contact")] // get req for /contact

        public ViewResult Index(){
            return View();
        }
    }
}