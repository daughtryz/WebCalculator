using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWeb.Services.Contracts
{
    public interface ICalculatorsService
    {
        double Calculate(double firstOperand,string operatorValue,double secondOperand);

    }
}
