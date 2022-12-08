using Microsoft.AspNetCore.Mvc;
using ModelBindingExample1.Models;
using System.Diagnostics;

namespace ModelBindingExample1.Controllers
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

        [HttpPost]
        public string Index(string stdName, string stdEmail, string selectHobby)
        {
            string str = String.Format("Name = {0}, Email = {1}, Hobby = {2}", stdName, stdEmail, selectHobby);
            return str;
        }

        public IActionResult Form1()
        {
            return View();
        }

        public IActionResult Form2()
        {
            return View();
        }

        public IActionResult Privacy()
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