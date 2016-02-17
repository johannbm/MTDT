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

        public static Individual GetBestIndividual(List<Individual> individuals)
        {
            return individuals.Aggregate((i1, i2) => i1.fitness > i2.fitness ? i1 : i2);
        }

        public static Random GetRandom()
        {
            if (random == null)
            {
                random = new Random();
            }
            return random;
        }

        public static double GetFitnessSum(List<Individual> individual)
        {
            return individual.Sum(x => x.fitness);
        }

        public static double GetFitnessAverage(List<Individual> individual)
        {
            return GetFitnessSum(individual) / individual.Count;
        }

        public static double GetVariance(List<Individual> individual)
        {
            double squaredDifferenceSum = 0;
            double mean = GetFitnessAverage(individual);

            foreach (Individual p in individual)
            {
                squaredDifferenceSum += Math.Pow(p.fitness - mean, 2);
            }

            return squaredDifferenceSum / individual.Count;
        }

        public static double GetStandardDeviation(List<Individual> individual)
        {
            return Math.Sqrt(GetVariance(individual));
        }
    }
}
