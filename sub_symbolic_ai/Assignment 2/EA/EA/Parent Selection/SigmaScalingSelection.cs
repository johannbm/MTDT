using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SigmaScalingSelection : ParentSelectionStrategy
    {

        public override Dictionary<IPhenotype, double> ScaleValues(List<IPhenotype> candidates)
        {
            Dictionary<IPhenotype, double> scaledValues = new Dictionary<IPhenotype, double>();
            double mean = Utility.GetFitnessAverage(candidates);
            double std = Utility.GetStandardDeviation(candidates);

            foreach (IPhenotype p in candidates)
            {
                scaledValues.Add(p, GetSigmaScaledValue(p.fitness, mean, std));
            }

            return scaledValues;
        }

        private double GetSigmaScaledValue(double value, double mean, double std)
        {
            return 1 + ((value - mean) / (2 * std));
        }


    }
}
