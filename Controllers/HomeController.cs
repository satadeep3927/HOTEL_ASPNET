using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult architecture()
        {
            return View();
        }

        public IActionResult interior()
        {
            return View();
        }
        public IActionResult urbandesign()
        {
            return View();
        }
        
    }
}