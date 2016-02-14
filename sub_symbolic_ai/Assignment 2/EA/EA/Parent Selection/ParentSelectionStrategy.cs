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

        protected double GetFitnessAverage(List<IPhenotype> phenotypes)
        {
            return GetFitnessSum(phenotypes) / phenotypes.Count;
        }

        

        protected double GetVariance(List<IPhenotype> phenotypes)
        {
            double squaredDifferenceSum = 0;
            double mean = GetFitnessAverage(phenotypes);

            foreach (IPhenotype p in phenotypes)
            {
                squaredDifferenceSum += Math.Pow(p.fitness - mean, 2);
            }

            return squaredDifferenceSum / phenotypes.Count;
        }

        protected double GetStandardDeviation(List<IPhenotype> phenotypes)
        {
            return Math.Sqrt(GetVariance(phenotypes));
        }


        public virtual List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents)
        {
            double averageFitness = GetFitnessAverage(candidates);
            double standardDeviation = GetStandardDeviation(candidates);

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
