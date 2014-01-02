using MyMefContract;

namespace DivideCalculation
{
    [AdvancedCalculationExport(CalculationType = CalculationType.Divide, ZeroOperatorNotAllowed = true)]
    public class DivideCalculation : ICalculator
    {
        public double GetNumber(int op1, int op2)
        {
            // ReSharper disable once PossibleLossOfFraction
            return op1 / op2;
        }
    }
}
