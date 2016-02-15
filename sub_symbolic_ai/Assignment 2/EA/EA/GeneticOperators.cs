using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public static class GeneticOperators
    {

        public static void BitVector_Mutate(BinaryGenotype genotype, double mutationProbability)
        {
            int[] newBinaryVector = new int[genotype.binaryVector.Length];
            int[] binaryVector = genotype.binaryVector;

            for (int i = 0; i < binaryVector.Length; i++)
            {
                if (Utility.GetRandom().NextDouble() < mutationProbability)
                {
                    binaryVector[i] = (binaryVector[i] == 0) ? 1 : 0;
                }
            }

        }

        public static BinaryGenotype BitVector_OnePointCrossOver(BinaryGenotype g1, BinaryGenotype g2)
        {
            int point = Utility.GetRandom().Next(1, g1.binaryVector.Length-1);

            int[] newBitVector = new int[g1.binaryVector.Length];

            for (int i = 0; i < newBitVector.Length; i++)
            {
                newBitVector[i] = (point < i) ? g1.binaryVector[i] : g2.binaryVector[i];
            }

            return new BinaryGenotype(newBitVector);
        }


        // Testing purposes
        public static BinaryGenotype BitVector_OnePointCrossOverTesting(BinaryGenotype g1, BinaryGenotype g2, int point)
        {
            //int point = Utility.GetRandom().Next(1, g1.binaryVector.Length - 1);

            int[] newBitVector = new int[g1.binaryVector.Length];

            for (int i = 0; i < newBitVector.Length; i++)
            {
                newBitVector[i] = (point > i) ? g1.binaryVector[i] : g2.binaryVector[i];
            }

            return new BinaryGenotype(newBitVector);
        }

    }
}
