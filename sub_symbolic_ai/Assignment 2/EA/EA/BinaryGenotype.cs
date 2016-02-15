using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryGenotype : IGenotype
    {
        public int[] binaryVector { get; set; }

        public IPhenotype developedPhenotype { get; set; }

        //Random Genotype
        public BinaryGenotype(int length)
        {
            binaryVector = new int[length];

            for (int i = 0; i < length; i++)
            {
                binaryVector[i] = (Utility.GetRandom().NextDouble() < 0.5) ? 1 : 0;
            }
        }


        public BinaryGenotype(int[] binaryVector)
        {
            this.binaryVector = binaryVector;
        }

        public BinaryGenotype CreateRandomGenotypes<BinaryGenotype>()
        {
            throw new NotImplementedException();
        }
    }
}
