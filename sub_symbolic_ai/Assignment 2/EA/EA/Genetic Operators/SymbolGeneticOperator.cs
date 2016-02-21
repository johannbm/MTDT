using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SymbolGeneticOperator : IGeneticOperators
    {
        public void Mutate(Individual individual, double mutationProbability)
        {
            SymbolIndividual symbolIndividual = ((SymbolIndividual)individual);

            int[] symbolVector = symbolIndividual.genotype;

            for (int i = 0; i < symbolVector.Length; i++)
            {
                if (Utility.GetRandom().NextDouble() < mutationProbability)
                {
                    symbolVector[i] = Utility.GetRandom().Next(SymbolIndividual.symbolSize);
                }
            }
        }

        public Individual OnePointCrossOver(Individual individual1, Individual individual2)
        {
            SymbolIndividual binaryIndividual1 = (SymbolIndividual)individual1;
            SymbolIndividual binaryIndividual2 = (SymbolIndividual)individual2;

            int point = Utility.GetRandom().Next(1, binaryIndividual1.genotype.Length - 1);

            int[] newBitVector = new int[binaryIndividual1.genotype.Length];

            for (int i = 0; i < newBitVector.Length; i++)
            {
                newBitVector[i] = (point > i) ? binaryIndividual1.genotype[i] : binaryIndividual2.genotype[i];
            }

            return new SymbolIndividual(newBitVector);
        }
    }
}
