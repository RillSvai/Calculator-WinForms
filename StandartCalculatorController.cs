using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class StandartCalculatorController
    {
        static public void ClearHistory(ICalculator calculator)
        {
            calculator.History = string.Empty;
        }
        static public void ApplyOperation(ICalculator _calculator) => _calculator.Result = _calculator.Operation switch
        {
            "+" => Convert.ToDecimal(_calculator.SecondValue) + Convert.ToDecimal(_calculator.FirstValue),
            "-" => Convert.ToDecimal(_calculator.FirstValue) - Convert.ToDecimal(_calculator.SecondValue),
            "x" => Convert.ToDecimal(_calculator.SecondValue) * Convert.ToDecimal(_calculator.FirstValue),
            "÷" => Convert.ToDecimal(_calculator.FirstValue) / Convert.ToDecimal(_calculator.SecondValue),
            "sqrt" => Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(_calculator.FirstValue))),
            "inverse" => 1.0m / Convert.ToDecimal(_calculator.FirstValue),
            "pow" => (decimal)Math.Pow(Convert.ToDouble(_calculator.FirstValue), 2),
        };
    }
}
