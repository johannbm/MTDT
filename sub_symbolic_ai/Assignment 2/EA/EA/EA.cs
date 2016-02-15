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
        public IPhenotype phenotype { get; set; }
        public IGenotype genotype { get; set; }
        public IDevelopmentMethod developmentMethod { get; set; }
        public IAdultSelectionStrategy adultSelectionStrategy { get; set; }
        public ParentSelectionStrategy parentSelectionStrategy { get; set; }

        public EA()
        {

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
                foreach (IPhenotype phenotype in phenotypes)
                {
                    fitnessCalculator.CalculateFitness(phenotype);
                }

                //Adult selection

                //Parent selection

                //Mutation


                numOfGenerations++;
            }
        } 

       


    }
}
