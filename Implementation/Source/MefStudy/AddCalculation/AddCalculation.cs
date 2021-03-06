﻿using System.ComponentModel.Composition;
using MyMefContract;

namespace AddCalculation
{
    [CalculationExport(CalculationType = CalculationType.Add)]
    public class AddCalculation : ICalculator
    {
        public double GetNumber(int op1, int op2)
        {
            return op1 + op2;
        }
    }
}
