﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class Individual
    {
        public double fitness { get; set; }

        public abstract Individual Clone();
        public abstract String ToPhenotypeString();
    }
}
