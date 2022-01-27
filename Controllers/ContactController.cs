using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("contact")]
        public string Index(){
            return "This is my contact controller route '/contact' !";
        }
    }
}