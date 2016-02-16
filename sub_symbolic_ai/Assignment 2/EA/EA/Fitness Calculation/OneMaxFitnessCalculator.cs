using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class OneMaxFitnessCalculator : IFitnessCalculator
    {

        public int[] goal { get; set; }

        public OneMaxFitnessCalculator(int[] goal)
        {
            this.goal = goal;
        }

        public void CalculateAndSetFitness(Individual[] individuals)
        {
            foreach (Individual i in individuals)
            {
                CalculateAndSetFitness(i);
            }
        }

        public void CalculateAndSetFitness(Individual individual)
        {
            individual.fitness = CalculateFitness(individual);
        }

        public double CalculateFitness(Individual individual)
        {
            int score = 0;
            int[] phenotype = ((BinaryIndividual)individual).phenotype;

            for (int i = 0; i < goal.Length; i++)
            {
                score += 1 - Math.Abs(phenotype[i] - goal[i]);
            }

            return score;
        }
    }
}
