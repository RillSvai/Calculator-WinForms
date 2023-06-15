﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        static public void ApplyOperation(ICalculator calculator) => calculator.Result = calculator.Operation switch
        {
            "+" => Convert.ToDecimal(calculator.SecondValue) + Convert.ToDecimal(calculator.FirstValue),
            "-" => Convert.ToDecimal(calculator.FirstValue) - Convert.ToDecimal(calculator.SecondValue),
            "x" => Convert.ToDecimal(calculator.SecondValue) * Convert.ToDecimal(calculator.FirstValue),
            "÷" => Convert.ToDecimal(calculator.FirstValue) / Convert.ToDecimal(calculator.SecondValue),
            "sqrt" => Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(calculator.FirstValue))),
            
        };
        static public void ApplyUnaryOperation(ICalculator calculator)
        {
            calculator.SecondValue = calculator.Operation switch
            {
                "√" => Math.Sqrt(Convert.ToDouble(calculator.SecondValue)).ToString(),
                "inverse" => (1.0 / Convert.ToDouble(calculator.SecondValue)).ToString(),
                "pow" => Math.Pow(Convert.ToDouble(calculator.SecondValue), 2).ToString()
            };
            if (calculator.FirstValue == "0") (calculator.SecondValue,calculator.FirstValue) = (calculator.FirstValue,calculator.SecondValue);
        }
    }
}
