using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EA;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATesting
{
    [TestClass]
    public class GeneticOperatorsTest
    {

        [TestMethod]
        public void BinaryMutationTest()
        {
            BinaryIndividual bg = new BinaryIndividual(new int[] { 0, 0, 0, 0 });
            BinaryGeneticOperator bgo = new BinaryGeneticOperator();
            bgo.Mutate(bg, 0.6);
            DebugBinaryVector(bg.genotype);
        }

        [TestMethod]
        public void BinaryCrossoverTest()
        {
            BinaryIndividual bg1 = new BinaryIndividual(new int[] { 0, 0, 0, 0 });
            BinaryIndividual bg2 = new BinaryIndividual(new int[] { 0, 1, 0, 1 });
            BinaryIndividual bg3 = new BinaryIndividual(new int[] { 0, 0, 1, 0 });
            BinaryIndividual bg4 = new BinaryIndividual(new int[] { 0, 0, 0, 1 });
            BinaryIndividual bg5 = new BinaryIndividual(new int[] { 1, 0, 0, 0 });
            BinaryIndividual bg6 = new BinaryIndividual(new int[] { 0, 1, 1, 0 });

            BinaryIndividual res = BinaryGeneticOperator.BitVector_OnePointCrossOverTesting(bg1, bg2, 2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.genotype);

            res = BinaryGeneticOperator.BitVector_OnePointCrossOverTesting(bg1, bg2, 2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.genotype);

            res = BinaryGeneticOperator.BitVector_OnePointCrossOverTesting(bg1, bg2, 3);
            DebugBinaryVector(res.genotype);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.genotype);

            res = BinaryGeneticOperator.BitVector_OnePointCrossOverTesting(bg2, bg3, 2);
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 0 }, res.genotype);

            res = BinaryGeneticOperator.BitVector_OnePointCrossOverTesting(bg5, bg6, 1);
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 0 }, res.genotype);
        }




        public void DebugBinaryVector(int[] vector)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Binary Vector: ");
            foreach (int i in vector)
            {
                sb.Append(i + " ");
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
