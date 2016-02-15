using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryPhenotype : IPhenotype
    {
        public double fitness { get; set; }
        public int[] binaryVector { get; set; }
        public IGenotype genotypeParent { get; set; }


        public BinaryPhenotype(int[] binaryVector)
        {
            this.binaryVector = binaryVector;
        }

        // For testing
        public BinaryPhenotype(double fitness)
        {
            this.fitness = fitness;
        }

    }
}
