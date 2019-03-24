using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_All_Assignments.Models
{
    public class Calculator
    {
        private double Answer { get; set; }

        public double Calculation(double firstNumber, char operater, double secondNumber)
        {
            // Does the addition once. Will make it possible to keep on adding to the number afterwards.
            // Will need to use Session for it.
            if (operater == '+')
            {
                Answer = firstNumber + secondNumber;
            }
            // Does the subtraction once. Will make it possible to keep on adding to the number afterwards.
            // Will need to use Session for it.
            else if (operater == '-')
            {
                Answer = firstNumber - secondNumber;
            }
            else if (operater == '*')
            {
                Answer = firstNumber * secondNumber;
            }
            else if (operater == '/')
            {
                Answer = firstNumber / secondNumber;
            }
            else
            {
                string Answer = "Incorrect operator input. Please select either '+', '-', '*' or '/'";
                return Convert.ToDouble(Answer);
            }
            return Answer;
        }

    }
}
