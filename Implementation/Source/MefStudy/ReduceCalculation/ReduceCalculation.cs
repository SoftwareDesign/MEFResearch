﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyMefContract;

namespace ReduceCalculation
{
    [CalculationExport(CalculationType = CalculationType.Reduce)]
    public class ReduceCalculation : ICalculator
    {
        public double GetNumber(int op1, int op2)
        {
            return op1 - op2;
        }
    }
}
