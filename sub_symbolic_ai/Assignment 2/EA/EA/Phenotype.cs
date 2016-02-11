using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class Phenotype : IPhenotype
    {
        public double fitness { get; set; }

        public Phenotype()
        {

        }

        public Phenotype(double fitness)
        {
            this.fitness = fitness;
        }

    }
}
