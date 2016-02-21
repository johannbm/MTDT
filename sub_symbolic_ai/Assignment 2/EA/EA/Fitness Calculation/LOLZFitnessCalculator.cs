using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class LOLZFitnessCalculator : FitnessCalculator
    {

        public int zeroLimit { get; set; }

        public LOLZFitnessCalculator(int zeroLimit)
        {
            this.zeroLimit = zeroLimit;
        }

        public override double CalculateFitness(Individual individual)
        {
            BinaryIndividual binaryIndividual = (BinaryIndividual)individual;
            int numOfLeadingDenomination = 0;
            int firstDigit = binaryIndividual.phenotype[0];

            for (int i = 0; i < binaryIndividual.phenotype.Length; i++)
            {
                if (binaryIndividual.phenotype[i] == firstDigit)
                {
                    numOfLeadingDenomination++;
                }
                else
                {
                    break;
                }
            }

            return (firstDigit == 0 && numOfLeadingDenomination > zeroLimit) ? zeroLimit : numOfLeadingDenomination;
        }
    }
}
