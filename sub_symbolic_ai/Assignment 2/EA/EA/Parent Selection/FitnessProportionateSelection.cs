using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class FitnessProportionateSelection : ParentSelectionStrategy
    {

        public override List<Individual> selectParents(List<Individual> candidates, int numberOfParents)
        {
            double fitnessSum = Utility.GetFitnessSum(candidates);
            List<Individual> winners = new List<Individual>();

            RouletteWheel rw = new RouletteWheel();

            foreach (Individual p in candidates)
            {
                rw.AddPhenotype(p, p.fitness / fitnessSum);
            }

            for (int i = 0; i < numberOfParents; i++)
            {
                winners.Add(rw.spinWheel());
            }

            return winners;
        }
    }
}
