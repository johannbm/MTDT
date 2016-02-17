using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EA
{
    class EA
    {

        public int maxNumOfGenerations { get; set; }
        public double maxFitness { get; set; }
        public int amountOfChildrenToCreate { get; set; }
        public double crossOverRate { get; set; }
        public double mutationRate { get; set; }

        public int childPopulation { get; set; }
        public int adultPopulation { get; set; }

        public IFitnessCalculator fitnessCalculator { get; set; }
        public IDevelopmentMethod developmentMethod { get; set; }
        public IAdultSelectionStrategy adultSelectionStrategy { get; set; }
        public ParentSelectionStrategy parentSelectionStrategy { get; set; }
        public IGeneticOperators geneticOperators { get; set; }

        public List<Individual> previousPopulation;
        public List<Individual> population;

        public EA(List<Individual> population, int maxNumOfGenerations, int maxFitness)
        {
            this.population = population;
            this.maxNumOfGenerations = maxNumOfGenerations;
            this.maxFitness = maxFitness;
            previousPopulation = new List<Individual>();
        }

        public void Run()
        {
            //Initialize random population (Genotypes)
            int numOfGenerations = 0;
            double bestFitness = 0;

            while (numOfGenerations < maxNumOfGenerations)
            {

                //Develop (Genotypes -> Phenotypes)
                developmentMethod.DevelopGenotypes(population);

                //Fitness testing
                fitnessCalculator.CalculateAndSetFitness(population);

                Console.WriteLine("Generation: " + numOfGenerations);
                Console.WriteLine(Utility.GetBestIndividual(population));

                bestFitness = Utility.GetBestIndividual(population).fitness;

                if (bestFitness >= maxFitness)
                    break;

                //Adult selection
                population = adultSelectionStrategy.adultSelection(previousPopulation, population);

                

                //Parent selection
                population = parentSelectionStrategy.selectParents(population, childPopulation);

                //int ii = 1;
                //foreach (Individual i in population)
                //{
                //    Console.WriteLine(ii + " " + i.ToString());
                //    ii++;
                //}
                //Console.ReadLine();

                //Mutation
                previousPopulation = population;
                population = ModifyGenetics(population);

                

                numOfGenerations++;
                
            }
            developmentMethod.DevelopGenotypes(population);
            fitnessCalculator.CalculateAndSetFitness(population);
            Individual best = Utility.GetBestIndividual(population);
            Console.WriteLine(Utility.GetBestIndividual(population));

        }

        public List<Individual> ModifyGenetics(List<Individual> individuals)
        {
            List<Individual> newGeneration = new List<Individual>();

            while (newGeneration.Count < individuals.Count - 1)
            {
                double randomChoice = Utility.GetRandom().NextDouble();
                Individual parent1 = individuals[Utility.GetRandom().Next(individuals.Count)];
                Individual parent2 = individuals[Utility.GetRandom().Next(individuals.Count)];



                if (randomChoice < crossOverRate)
                {
                    // Do Crossover
                    newGeneration.Add(geneticOperators.OnePointCrossOver(parent1, parent2));
                    newGeneration.Add(geneticOperators.OnePointCrossOver(parent1, parent2));
                }
                else
                {
                    newGeneration.Add(parent1.Clone());
                    newGeneration.Add(parent2.Clone());

                }
            }

            // Mutate every child
            newGeneration.ForEach(x => geneticOperators.Mutate(x, mutationRate));

            return newGeneration;
        }

       


    }
}
