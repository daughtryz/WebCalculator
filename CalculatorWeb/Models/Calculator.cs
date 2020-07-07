using CalculatorWeb.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWeb.Models
{
    public class Calculator
    {
        private readonly ICalculatorsService calculatorsService;
        private double firstOperand;
        private double secondOperand;
        private string operatorValue;
        public Calculator(double firstOperand, string operatorValue, double secondOperand,ICalculatorsService calculatorsService)
        {
            this.FirstOperand = firstOperand;
            this.OperatorValue = operatorValue;
            this.SecondOperand = secondOperand;
            this.calculatorsService = calculatorsService;
        }

        public double GetResult => this.calculatorsService.Calculate(this.FirstOperand, this.OperatorValue, this.SecondOperand);
        public double FirstOperand
        {
            get { return this.firstOperand; }
            set
            {

                if (value.GetType().Name != "Double")
                {
                    throw new Exception("No such operand!");
                }
                this.firstOperand = value;
            }
        }

        public string OperatorValue
        {
            get { return operatorValue; }
            set
            {
                if (value != "+" && value != "-" && value != "*" && value != "/")
                {
                    throw new Exception("No such operator");
                }
                operatorValue = value;
            }
        }

        public double SecondOperand
        {
            get { return this.secondOperand; }
            set
            {

                if (value.GetType().Name != "Double")
                {
                    throw new Exception("No such operand!");
                }
                this.secondOperand = value;
            }
        }
    }
}
