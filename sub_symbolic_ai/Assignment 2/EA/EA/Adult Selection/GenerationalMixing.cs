using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class GenerationalMixing : IAdultSelectionStrategy
    {
        public List<Individual> adultSelection(List<Individual> adults, List<Individual> children)
        {
            if (adults.Count == 0)
                return children;

            int populationSize = adults.Count;

            adults.AddRange(children);

            // Return best adultPoolSize best children.
            return (from p in adults
                    orderby p.fitness descending
                    select p).Take(populationSize).ToList();
        }
    }
}
