﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyMefContract
{
    public enum CalculationType
    {
        Add,
        Reduce,
        Multiply,
        Divide
    }

    public interface ICaculatorMetadata
    {
        CalculationType CalculationType { get; }

        [DefaultValue(false)]
        bool ZeroOperatorNotAllowed { get; }
    }
}
