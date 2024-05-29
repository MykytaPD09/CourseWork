using gas_station.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gas_station.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Fuel()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Reg()
        {
            return View();
        }

        public IActionResult Shares()
        {
            return View();
        }

        public IActionResult Fail()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult RegComp()
        {
            return View();
        }

        public IActionResult FailReg()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}