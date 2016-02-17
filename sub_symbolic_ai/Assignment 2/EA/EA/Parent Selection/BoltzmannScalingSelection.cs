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

        public override Dictionary<Individual, double> ScaleValues(List<Individual> candidates)
        {
            Dictionary<Individual, double> scaledValues = new Dictionary<Individual, double>();
            double mean = Utility.GetFitnessAverage(candidates);

            foreach (Individual p in candidates)
            {
                scaledValues.Add(p, GetBoltzmannValue(p.fitness, mean, temp));
            }

            return scaledValues;
        }


        private double GetBoltzmannValue(double value, double mean, double temp)
        {
            return (Math.Pow(Math.E, (value / temp)) / (Math.Pow(Math.E, (mean / temp))));
        }

    }
}
