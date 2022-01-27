using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller {
        
        [HttpGet("projects")] // get req for /projects

        public ViewResult Index(){
            return View();
        }
    }
}