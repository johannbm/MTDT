using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SigmaScalingSelection : ParentSelectionStrategy
    {

        public override Dictionary<Individual, double> ScaleValues(List<Individual> candidates)
        {
            Dictionary<Individual, double> scaledValues = new Dictionary<Individual, double>();
            double mean = Utility.GetFitnessAverage(candidates);
            double std = Utility.GetStandardDeviation(candidates);

            foreach (Individual p in candidates)
            {
                scaledValues.Add(p, GetSigmaScaledValue(p.fitness, mean, std));
            }

            return scaledValues;
        }

        private double GetSigmaScaledValue(double value, double mean, double std)
        {
            if (std == 0)
                return 1;
            return 1 + ((value - mean) / (2 * std));
        }


    }
}
