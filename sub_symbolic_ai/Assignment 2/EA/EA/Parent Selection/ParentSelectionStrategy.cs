using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class ParentSelectionStrategy
    {
        protected double GetFitnessSum(List<IPhenotype> phenotypes)
        {
            return phenotypes.Sum(x => x.fitness);
        }

        public abstract List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents);

    }
}
