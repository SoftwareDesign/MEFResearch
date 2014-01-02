using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace MyMefContract
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CalculationExportAttribute : ExportAttribute
    {
        public CalculationExportAttribute()
            : base(typeof(ICalculator))
        {
        }

        public CalculationType CalculationType { get; set; }
    }
}
