using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SymbolDevelopment : DevelopmentMethod
    {
        public override void DevelopGenotype(Individual individual)
        {
            SymbolIndividual binaryIndividual = ((SymbolIndividual)individual);
            binaryIndividual.phenotype = (int[])binaryIndividual.genotype.Clone();
        }
    }
}
