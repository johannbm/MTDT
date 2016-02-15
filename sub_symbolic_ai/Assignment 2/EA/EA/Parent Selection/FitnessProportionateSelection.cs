using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class FitnessProportionateSelection : ParentSelectionStrategy
    {

        public override List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents)
        {
            double fitnessSum = Utility.GetFitnessSum(candidates);
            List<IPhenotype> winners = new List<IPhenotype>();

            RouletteWheel rw = new RouletteWheel();

            foreach (IPhenotype p in candidates)
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
