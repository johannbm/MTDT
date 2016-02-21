using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class DevelopmentMethod
    {

        public void DevelopGenotypes(List<Individual> individuals)
        {
            individuals.ForEach(x => DevelopGenotype(x));
        }

        public abstract void DevelopGenotype(Individual individual);
    }
}
