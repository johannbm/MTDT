using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BoltzmannScalingSelection : ParentSelectionStrategy
    {
        public double temp { get; set; }

        public BoltzmannScalingSelection(double temp)
        {
            this.temp = temp;
        }

        public override List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfParents)
        {

            double mean = GetFitnessAverage(candidates);

            Dictionary<IPhenotype, double> boltzmannScaledValues = new Dictionary<IPhenotype, double>();

            double boltzmannTotal = 0;

            foreach (IPhenotype p in candidates)
            {
                double sigmaScaledFitness = GetBoltzmannValue(p.fitness, mean, temp);
                boltzmannScaledValues.Add(p, sigmaScaledFitness);
                boltzmannTotal += sigmaScaledFitness;
            }


            RouletteWheel rw = new RouletteWheel();

            foreach (IPhenotype key in boltzmannScaledValues.Keys.ToList())
            {
                rw.AddPhenotype(key, boltzmannScaledValues[key] / boltzmannTotal);
            }

            List<IPhenotype> winners = new List<IPhenotype>();

            for (int i = 0; i < numberOfParents; i++)
            {
                winners.Add(rw.spinWheel());
            }

            return winners;
        }

        private double GetBoltzmannValue(double value, double mean, double temp)
        {
            return (Math.Pow(Math.E, (value / temp)) / (Math.Pow(Math.E, (mean / temp))));
        }
    }
}
