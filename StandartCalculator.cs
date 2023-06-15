using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class StandartCalculator : ICalculator
    {
        private string _history;
        private decimal _result = 0;
        private string _firstValue;
        private string _operation;
        private string _secondValue;
        public string History
        {
            get => _history;
            set => _history = value;
        }
        public decimal Result
        {
            get => _result;
            set => _result = value;
        }
        public string FirstValue
        {
            get => _firstValue;
            set => _firstValue = value;
        }
        public string Operation
        {
            get => _operation;
            set => _operation = value;
        }
        public string SecondValue { get => _secondValue; set => _secondValue = value; }
        public void Clear() 
        {
            _operation = string.Empty;
            _secondValue = string.Empty;
            _firstValue = string.Empty;
            _result = 0;
        }
    }
}
