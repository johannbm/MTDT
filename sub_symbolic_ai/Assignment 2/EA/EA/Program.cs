using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    class Program
    {
        static void Main(string[] args)
        {
            int populationSize = 12;
            int noOfBits = 40;
            int[] goal = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };


            // Initialize a population
            List<Individual> population = new List<Individual>();
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new BinaryIndividual(noOfBits));
            }

            //Build EA
            EA ea = new EA(population, 0,0);
            ea.developmentMethod = new BinaryDevelopment();
            ea.fitnessCalculator = new OneMaxFitnessCalculator(goal);
            ea.adultSelectionStrategy = new FullGenerationalReplacement();
            ea.parentSelectionStrategy = new SigmaScalingSelection();
            ea.geneticOperators = new BinaryGeneticOperator();

            // Run EA

        }
    }
}
