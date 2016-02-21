using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public abstract class FitnessCalculator
    {


        public void CalculateAndSetFitness(List<Individual> individuals)
        {
            individuals.ForEach(x => CalculateAndSetFitness(x));
        }

        public void CalculateAndSetFitness(Individual individual)
        {
            individual.fitness = CalculateFitness(individual);
        }

        public abstract double CalculateFitness(Individual individual);

    }
}
