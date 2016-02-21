using System;
using System.Collections.Generic;
using System.ComponentModel;




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

        public FitnessCalculator fitnessCalculator { get; set; }
        public DevelopmentMethod developmentMethod { get; set; }
        public IAdultSelectionStrategy adultSelectionStrategy { get; set; }
        public ParentSelectionStrategy parentSelectionStrategy { get; set; }
        public IGeneticOperators geneticOperators { get; set; }

        public List<Individual> previousPopulation;
        public List<Individual> population { get; set; }

        public EA()
        {
            previousPopulation = new List<Individual>();
        }

        public List<double> Run(BackgroundWorker bgWorker)
        {
            //Initialize random population (Genotypes)
            int numOfGenerations = 0;
            double bestFitness = 0;
            List<double> log = new List<double>();

            while (numOfGenerations < maxNumOfGenerations)
            {
                if (bgWorker.CancellationPending)
                    return null;

                //Develop (Genotypes -> Phenotypes)
                developmentMethod.DevelopGenotypes(population);

                //Fitness testing
                fitnessCalculator.CalculateAndSetFitness(population);

                bestFitness = Utility.GetBestIndividual(population).fitness;

                // Report findings to bgWorker
                bgWorker.ReportProgress(0, new Tuple<int, double>(numOfGenerations, bestFitness));

                log.Add(bestFitness);

                if (bestFitness >= maxFitness)
                {
                    Console.WriteLine("Best phenotype: " + Utility.GetBestIndividual(population));
                    break;
                }

                //Adult selection
                population = adultSelectionStrategy.adultSelection(previousPopulation, population);

                //Parent selection
                population = parentSelectionStrategy.selectParents(population, adultPopulation);

                //Mutation
                previousPopulation = Utility.ClonePopulation(population);
                population = ModifyGenetics(population);

                

                numOfGenerations++;
                
            }
            developmentMethod.DevelopGenotypes(population);
            fitnessCalculator.CalculateAndSetFitness(population);
            Individual best = Utility.GetBestIndividual(population);

            return log;

        }

        

        public List<Individual> ModifyGenetics(List<Individual> individuals)
        {
            List<Individual> newGeneration = new List<Individual>();

            while (newGeneration.Count < childPopulation)
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
