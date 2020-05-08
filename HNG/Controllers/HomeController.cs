using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HNG.Models;

namespace HNG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       /* public IActionResult Index()
        {
            return View();
        } */
         
         [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string name)
        {
            string name1 = name;
            int number1 = Convert.ToInt16(firstNumber);
            double sqrtNumber1 = Math.Sqrt(number1);
            int number2 = Convert.ToInt16(secondNumber);
            double sqrtNumber2 = Math.Sqrt(number2);
            ViewBag.Result1 = sqrtNumber1;
            ViewBag.Result2 = sqrtNumber2;
            ViewBag.Result3 = number1;
            ViewBag.Result4 = number2;
            ViewBag.name1 = name;
            

            return View();
        }

        public IActionResult Profile()
        {
           return View();
        }

        public IActionResult Tasks()
        {
           return View();
        }

        public IActionResult Score_board()
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
