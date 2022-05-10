using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class ProjectController : Controller
    {
        
        public IActionResult cottonhouse()
        {
            return View();
        }

        public IActionResult armadacenter()
        {
            return View();
        }
        
    }
}