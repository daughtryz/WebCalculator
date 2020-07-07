using CalculatorWeb.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWeb.Services
{
    public class CalculatorsService : ICalculatorsService
    {
        private double result = 0;
        public double Calculate(double firstOperand, string operatorValue, double secondOperand)
        {
            switch (operatorValue)
            {
                case "+": this.result = firstOperand + secondOperand;
                    break;
                case "-":
                    this.result = firstOperand - secondOperand;
                    break;
                case "*":
                    this.result = firstOperand * secondOperand;
                    break;
                case "/":
                    this.result = firstOperand / secondOperand;
                    break;
                default:
                    Console.WriteLine("No such operator");
                    break;
            }

            return this.result;
        }
    }
}
