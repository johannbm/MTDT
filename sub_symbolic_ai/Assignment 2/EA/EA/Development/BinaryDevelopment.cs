using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryDevelopment : DevelopmentMethod
    {
        
        public override void DevelopGenotype(Individual individual)
        {
            BinaryIndividual binaryIndividual = ((BinaryIndividual)individual);
            binaryIndividual.phenotype = (int[])binaryIndividual.genotype.Clone();
        }
    }
}
