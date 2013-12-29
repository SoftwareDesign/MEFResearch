using System.ComponentModel.Composition;
using MyMefContract;

namespace AddCalculation
{
    [Export(typeof(ICalculator))]
    public class AddCalculation : ICalculator
    {
        public double GetNumber(int op1, int op2)
        {
            return op1 + op2;
        }
    }
}
