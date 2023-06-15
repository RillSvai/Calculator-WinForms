using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        string History { get; set; }
        decimal Result { get; set; }
        string FirstValue { get; set; }
        string SecondValue { get; set; }
        string Operation { get; set; }
        void Clear();
    }
}
