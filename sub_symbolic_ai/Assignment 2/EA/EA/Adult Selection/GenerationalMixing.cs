using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class GenerationalMixing : IAdultSelectionStrategy
    {
        public List<IPhenotype> adultSelection(List<IPhenotype> adults, List<IPhenotype> children)
        {
            int populationSize = adults.Count;

            adults.AddRange(children);

            // Return best adultPoolSize best children.
            return (from p in adults
                    orderby p.fitness descending
                    select p).Take(populationSize).ToList();
        }
    }
}
