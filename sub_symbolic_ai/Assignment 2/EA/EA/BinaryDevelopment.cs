using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class BinaryDevelopment : IDevelopmentMethod
    {
        public void DevelopGenotypes(List<Individual> genotypes)
        {
            genotypes.ForEach(x => DevelopGenotype(x));
        }

        public void DevelopGenotype(Individual individual)
        {
            BinaryIndividual binaryIndividual = ((BinaryIndividual)individual);
            binaryIndividual.phenotype = (int[])binaryIndividual.genotype.Clone();
        }
    }
}
