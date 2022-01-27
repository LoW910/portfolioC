using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller {
        
        [HttpGet("projects")]
        public string Index(){
            return "This is my projects controller route '/projects' !";
        }
    }
}