using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public interface IGeneticOperators
    {
        void Mutate(Individual individual, double mutationProbability);
        Individual OnePointCrossOver(Individual individual1, Individual individual2);
    }
}
