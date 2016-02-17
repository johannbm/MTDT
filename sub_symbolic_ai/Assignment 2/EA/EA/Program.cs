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
            int populationSize = 20;
            int noOfBits = 40;

            int[] goal = new int[noOfBits];
            for (int i=0; i < noOfBits; i++)
            {
                goal[i] = 1;
            }


            // Initialize a population
            List<Individual> population = new List<Individual>();
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new BinaryIndividual(noOfBits));
            }

            foreach (Individual i in population)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();


            //Build EA
            EA ea = new EA(population, 0,0);
            ea.maxFitness = noOfBits;
            ea.maxNumOfGenerations = 100;
            ea.mutationRate = 0.01;
            ea.crossOverRate = 0.0;
            ea.adultPopulation = 20;
            ea.childPopulation = 30;
            ea.developmentMethod = new BinaryDevelopment();
            ea.fitnessCalculator = new OneMaxFitnessCalculator(goal);
            ea.adultSelectionStrategy = new GenerationalMixing();
            ea.parentSelectionStrategy = new FitnessProportionateSelection();
            ea.geneticOperators = new BinaryGeneticOperator();

            // Run EA
            ea.Run();

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
