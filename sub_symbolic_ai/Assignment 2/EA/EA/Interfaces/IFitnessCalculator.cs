using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    interface IFitnessCalculator
    {
        double CalculateFitness(IPhenotype phenotype);
        void CalculateAndSetFitness(IPhenotype phenotype);
        void CalculateAndSetFitness(IPhenotype[] phenotype);
    }
}
