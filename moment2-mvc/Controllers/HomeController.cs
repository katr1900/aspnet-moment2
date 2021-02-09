using System;
using Microsoft.AspNetCore.Mvc;
namespace Moment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }


}
    
