using assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_2.Controllers
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
            Customer[] customers = new Customer[4];
            customers[0] = new Customer()
            {
                customerId = 1200,
                customerName = "Deepthi",
                phoneNumber = "9392852783",
                productsBrought =10,
                totalBill=2400,
            };

            customers[1] = new Customer()
            {
                customerId = 1201,
                customerName = "Sahitya",
                phoneNumber = "7135677823",
                productsBrought = 25,
                totalBill = 4590,
            };

            customers[2] = new Customer()
            {
                customerId = 1202,
                customerName = "Geetha",
                phoneNumber = "8928897232",
                productsBrought = 12,
                totalBill = 3700,
            };

            customers[3] = new Customer()
            {
                customerId = 1203,
                customerName = "Bhavya",
                phoneNumber = "9848223465",
                productsBrought = 40,
                totalBill = 7070,
            };

            return View(customers);
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