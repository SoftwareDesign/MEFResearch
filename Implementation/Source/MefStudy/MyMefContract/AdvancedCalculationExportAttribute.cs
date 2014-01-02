using System;
using System.ComponentModel.Composition;

namespace MyMefContract
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AdvancedCalculationExportAttribute : ExportAttribute
    {
        public AdvancedCalculationExportAttribute()
            : base(typeof(ICalculator))
        {
        }

        public CalculationType CalculationType { get; set; }

        public bool ZeroOperatorNotAllowed { get; set; }
    }
}
