using assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace assignment_1.Controllers
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
            ViewBag.Heading = "Welcome to A to Z supermarket";
            //ViewBag.Time= DateTime.Now.ToString();

            int[] prices = new int[] { 25, 20, 100, 500, 800, 6000, 2500 };

            ViewData.Add("chips", prices[0]);
            ViewData.Add("waterbottle", prices[1]);
            ViewData.Add("detergent", prices[2]);
            ViewData.Add("ricebag", prices[3]);
            ViewData.Add("slippers", prices[4]);
            ViewData.Add("trolley", prices[5]);
            ViewData.Add("bag", prices[6]);



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
