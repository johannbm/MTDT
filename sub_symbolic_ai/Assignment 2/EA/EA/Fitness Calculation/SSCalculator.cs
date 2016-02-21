using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{

    public enum SSTypes { Local, Global}

    public class SSCalculator : FitnessCalculator
    {

        public SSTypes ssType { get; set; }

        public SSCalculator(SSTypes ssType)
        {
            this.ssType = ssType;
        }


        public override double CalculateFitness(Individual individual)
        {
            SymbolIndividual intIndividual = (SymbolIndividual)individual;
            if (ssType == SSTypes.Global)
            {
                return 1.0 / (1.0 + GetGlobalViolations(intIndividual.phenotype));
            }
            else
            {
                return 1.0 / (1.0 + GetViolations( intIndividual.phenotype ,0));
            }
            throw new NotImplementedException();
        }


        public int GetGlobalViolations(int [] phenotype)
        {
            int totalViolations = 0;

            for (int i = 0; i < phenotype.Length - 1; i++)
            {
                totalViolations += GetViolations(phenotype, i);
            }

            return totalViolations;
        }


        public int GetViolations(int[] phenotype, int distance)
        {
            List<Tuple<int, int>> occurances = new List<Tuple<int, int>>();

            for (int i = 0; i < phenotype.Length - distance - 1; i++)
            {
                occurances.Add(new Tuple<int, int>(phenotype[i], phenotype[i + distance + 1]));
            }

            return occurances.Count - occurances.Distinct().Count();
        }
    }
}
