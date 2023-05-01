using HW4_28_04_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW4_28_04_2023.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Congrats(CongratsViewModel congratsInfo)
        {
            return View(congratsInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}