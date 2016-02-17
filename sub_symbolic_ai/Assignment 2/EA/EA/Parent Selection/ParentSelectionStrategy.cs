using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class ParentSelectionStrategy
    {


        public virtual List<Individual> selectParents(List<Individual> candidates, int amountToCreate)
        {
            double averageFitness = Utility.GetFitnessAverage(candidates);
            double standardDeviation = Utility.GetStandardDeviation(candidates);

            Dictionary<Individual, double> scaledValues = ScaleValues(candidates);

            double total = scaledValues.Sum(x => x.Value);

            RouletteWheel rw = new RouletteWheel();

            foreach (Individual key in scaledValues.Keys.ToList())
            {
                rw.AddPhenotype(key, scaledValues[key] / total);
            }

            List<Individual> winners = new List<Individual>();

            for (int i = 0; i < amountToCreate; i++)
            {
                winners.Add(rw.spinWheel());
            }

            return winners;
        }



        public virtual Dictionary<Individual, double> ScaleValues(List<Individual> candidates)
        {
            return null;
        }

    }
}
