using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public interface IFitnessCalculator
    {
        double CalculateFitness(Individual individual);
        void CalculateAndSetFitness(Individual individual);
        void CalculateAndSetFitness(Individual[] individual);
    }
}
