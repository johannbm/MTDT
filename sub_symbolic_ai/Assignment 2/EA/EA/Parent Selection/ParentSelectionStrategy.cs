using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class ParentSelectionStrategy
    {


        public virtual List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents)
        {
            double averageFitness = Utility.GetFitnessAverage(candidates);
            double standardDeviation = Utility.GetStandardDeviation(candidates);

            Dictionary<IPhenotype, double> scaledValues = ScaleValues(candidates);

            double total = scaledValues.Sum(x => x.Value);

            RouletteWheel rw = new RouletteWheel();

            foreach (IPhenotype key in scaledValues.Keys.ToList())
            {
                rw.AddPhenotype(key, scaledValues[key] / total);
            }

            List<IPhenotype> winners = new List<IPhenotype>();

            for (int i = 0; i < numberOfParents; i++)
            {
                winners.Add(rw.spinWheel());
            }

            return winners;
        }



        public virtual Dictionary<IPhenotype, double> ScaleValues(List<IPhenotype> candidates)
        {
            return null;
        }

    }
}
