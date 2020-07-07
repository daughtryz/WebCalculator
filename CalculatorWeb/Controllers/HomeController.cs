using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorWeb.Models;
using CalculatorWeb.Services.Contracts;
using CalculatorWeb.Services;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculatorsService calculatorsService;

        public HomeController(ILogger<HomeController> logger,ICalculatorsService calculatorsService)
        {
            _logger = logger;
            this.calculatorsService = calculatorsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double firstOperand,string operatorValue,double secondOperand)
        {
            
            Calculator calculator = new Calculator(firstOperand, operatorValue, secondOperand, new CalculatorsService());

            ViewData["result"] = calculator.GetResult;
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
