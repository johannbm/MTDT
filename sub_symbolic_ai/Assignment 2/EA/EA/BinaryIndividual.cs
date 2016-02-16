using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryIndividual : Individual
    {
        public int[] genotype { get; set; }
        public int[] phenotype { get; set; }


        //Random Genotype
        public BinaryIndividual(int length)
        {
            genotype = new int[length];

            for (int i = 0; i < length; i++)
            {
                genotype[i] = (Utility.GetRandom().NextDouble() < 0.5) ? 1 : 0;
            }
        }


        public BinaryIndividual(int[] binaryVector)
        {
            this.genotype = binaryVector;
        }

    }
}
