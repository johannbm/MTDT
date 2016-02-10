using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    class GenerationalMixing : IAdultSelectionStrategy
    {
        public List<IPhenotype> adultSelection(List<IPhenotype> adults, List<IPhenotype> children)
        {
            int populationSize = adults.Count;

            adults.AddRange(children);

            // Return best adultPoolSize best children.
            return (from p in children
                    orderby p.fitness
                    select p).Take(populationSize).ToList();
        }
    }
}
