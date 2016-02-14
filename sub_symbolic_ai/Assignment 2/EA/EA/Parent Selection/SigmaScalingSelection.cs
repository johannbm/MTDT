using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SigmaScalingSelection : ParentSelectionStrategy
    {


        public override List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents)
        {

            double averageFitness = GetFitnessAverage(candidates);
            double standardDeviation = GetStandardDeviation(candidates);

            Dictionary<IPhenotype, double> sigmaScaledValues = new Dictionary<IPhenotype, double>();

            double sigmaTotal = 0;

            foreach (IPhenotype p in candidates)
            {
                double sigmaScaledFitness = GetSigmaScaledValue(p.fitness, averageFitness, standardDeviation);
                sigmaScaledValues.Add(p, sigmaScaledFitness);
                sigmaTotal += sigmaScaledFitness;
            }


            RouletteWheel rw = new RouletteWheel();

            foreach (IPhenotype key in sigmaScaledValues.Keys.ToList())
            {
                rw.AddPhenotype(key, sigmaScaledValues[key] / sigmaTotal);
            }

            List<IPhenotype> winners = new List<IPhenotype>();

            for (int i = 0; i < numberOfParents; i++)
            {
                winners.Add(rw.spinWheel());
            }

            return winners;
        }

        private double GetSigmaScaledValue(double value, double mean, double std)
        {
            return 1 + ((value - mean) / (2 * std));
        }


    }
}
