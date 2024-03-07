using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ravens.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }

    }
}
