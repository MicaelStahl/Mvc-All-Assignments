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
            if (firstNumber.GetType() == typeof(double) && secondNumber.GetType() == typeof(double))
            {
                if (operater == '+' || operater == '-' || operater == '*' || operater == '/')
                {
                    double Answer = calculator.Calculation(firstNumber, operater, secondNumber);
                    ViewBag.Answer = $"The answer to {firstNumber} {operater} {secondNumber} is: {Answer}";
                    return View();
                }
            }
            ViewBag.WrongInput = "Wrong input. Please try again.";

            return View();
        }
    }
}