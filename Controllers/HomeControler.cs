using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // routes this HomeController will handle
        [HttpGet("")] // get req for /

        public string Index(){
            return "This is my Index route '/'";
        }

        
    }
}