using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    class EA
    {

        private int maxNumOfGenerations;
        private double maxFitness;

        private IFitnessCalculator fitnessCalculator;
        //private IPhenotype phenotype;
        //private IGenotype genotype;

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
