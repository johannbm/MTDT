using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class SymbolIndividual : Individual
    {
        public static int symbolSize { get; set; }

        public int[] genotype { get; set; }
        public int[] phenotype { get; set; }

        public SymbolIndividual(int length, int size)
        {
            genotype = new int[length];

            CreateRandom(length, size);
        }

        public SymbolIndividual(int length)
        {
            genotype = new int[length];

            CreateRandom(length, SymbolIndividual.symbolSize);
        }


        public SymbolIndividual(int[] integerVector)
        {
            this.genotype = integerVector;
        }

        private void CreateRandom(int length, int size)
        {
            for (int i = 0; i < length; i++)
            {
                genotype[i] = Utility.GetRandom().Next(size);
            }
        }

        public override string ToString()
        {
            string s = "Fitness: " + fitness;
            s += "Genotype: ";
            foreach (int i in genotype)
            {
                s += i + "|";
            }


            return s;
        }


        public override Individual Clone()
        {
            SymbolIndividual clone = new SymbolIndividual((int[])genotype.Clone());
            clone.fitness = this.fitness;
            return clone;
        }
    }
}
