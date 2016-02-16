using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryGeneticOperator : IGeneticOperators
    {


        public void Mutate(Individual individual, double mutationProbability)
        {
            BinaryIndividual binaryIndividual = (BinaryIndividual)individual;

            int[] newBinaryVector = new int[binaryIndividual.genotype.Length];
            int[] binaryVector = binaryIndividual.genotype;

            for (int i = 0; i < binaryVector.Length; i++)
            {
                if (Utility.GetRandom().NextDouble() < mutationProbability)
                {
                    binaryVector[i] = (binaryVector[i] == 0) ? 1 : 0;
                }
            }
        }

        public Individual OnePointCrossOver(Individual individual1, Individual individual2)
        {
            BinaryIndividual binaryIndividual1 = (BinaryIndividual)individual1;
            BinaryIndividual binaryIndividual2 = (BinaryIndividual)individual2;


            int point = Utility.GetRandom().Next(1, binaryIndividual1.genotype.Length - 1);

            int[] newBitVector = new int[binaryIndividual1.genotype.Length];

            for (int i = 0; i < newBitVector.Length; i++)
            {
                newBitVector[i] = (point > i) ? binaryIndividual1.genotype[i] : binaryIndividual2.genotype[i];
            }

            return new BinaryIndividual(newBitVector);
        }

        // Testing purposes
        public static BinaryIndividual BitVector_OnePointCrossOverTesting(Individual individual1, Individual individual2, int point)
        {
            BinaryIndividual binaryIndividual1 = (BinaryIndividual)individual1;
            BinaryIndividual binaryIndividual2 = (BinaryIndividual)individual2;


            //int point = Utility.GetRandom().Next(1, binaryIndividual1.genotype.Length - 1);

            int[] newBitVector = new int[binaryIndividual1.genotype.Length];

            for (int i = 0; i < newBitVector.Length; i++)
            {
                newBitVector[i] = (point > i) ? binaryIndividual1.genotype[i] : binaryIndividual2.genotype[i];
            }

            return new BinaryIndividual(newBitVector);
        }



    }
}
