using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_All_Assignments.Models;

namespace Mvc_All_Assignments.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double firstNumber, char operater, double secondNumber)
        {
            Calculator calculator = new Calculator();
            double answer = calculator.Calculation(firstNumber, operater, secondNumber);

            return View();
        }
    }
}