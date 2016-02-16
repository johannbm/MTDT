using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EA
{
    class EA
    {

        public int maxNumOfGenerations { get; }
        public double maxFitness { get; }

        public IFitnessCalculator fitnessCalculator { get; set; }
        public IDevelopmentMethod developmentMethod { get; set; }
        public IAdultSelectionStrategy adultSelectionStrategy { get; set; }
        public ParentSelectionStrategy parentSelectionStrategy { get; set; }
        public IGeneticOperators geneticOperators { get; set; }

        public List<Individual> population;

        public EA(List<Individual> initialPopulation, int maxNumOfGenerations, int maxFitness)
        {
            this.population = initialPopulation;
            this.maxNumOfGenerations = maxNumOfGenerations;
            this.maxFitness = maxFitness;
        }

        public void Run()
        {
            //Initialize random population (Genotypes)
            int numOfGenerations = 0;
            int bestFitness = 0;

            List<IPhenotype> phenotypes = new List<IPhenotype>();
            List<IGenotype> genotypes = new List<IGenotype>();

            while (numOfGenerations < maxNumOfGenerations || bestFitness < maxFitness)
            {
                //Develop (Genotypes -> Phenotypes)

                //Fitness testing
                

                //Adult selection

                //Parent selection

                //Mutation


                numOfGenerations++;
            }
        } 

       


    }
}
