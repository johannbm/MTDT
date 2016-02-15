using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public static class Utility
    {

        private static Random random;


        public static Random GetRandom()
        {
            if (random == null)
            {
                random = new Random();
            }
            return random;
        }

        public static double GetFitnessSum(List<IPhenotype> phenotypes)
        {
            return phenotypes.Sum(x => x.fitness);
        }

        public static double GetFitnessAverage(List<IPhenotype> phenotypes)
        {
            return GetFitnessSum(phenotypes) / phenotypes.Count;
        }

        public static double GetVariance(List<IPhenotype> phenotypes)
        {
            double squaredDifferenceSum = 0;
            double mean = GetFitnessAverage(phenotypes);

            foreach (IPhenotype p in phenotypes)
            {
                squaredDifferenceSum += Math.Pow(p.fitness - mean, 2);
            }

            return squaredDifferenceSum / phenotypes.Count;
        }

        public static double GetStandardDeviation(List<IPhenotype> phenotypes)
        {
            return Math.Sqrt(GetVariance(phenotypes));
        }
    }
}
