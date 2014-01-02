using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyMefContract;

namespace MultiplyCalculation
{
    [AdvancedCalculationExport(CalculationType = CalculationType.Multiply)]
    public class MultiplyCalculation : ICalculator
    {
        public double GetNumber(int op1, int op2)
        {
            return op1 * op2;
        }
    }
}
