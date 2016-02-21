using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class OneMaxFitnessCalculator : FitnessCalculator
    {

        public int[] goal { get; set; }

        public OneMaxFitnessCalculator(int[] goal)
        {
            this.goal = goal;
        }

        public override double CalculateFitness(Individual individual)
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
