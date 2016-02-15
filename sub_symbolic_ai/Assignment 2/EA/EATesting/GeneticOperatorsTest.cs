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
            BinaryGenotype bg = new BinaryGenotype(new int[] { 0, 0, 0, 0 });
            GeneticOperators.BitVector_Mutate(bg, 0.6);
            DebugBinaryVector(bg.binaryVector);
        }

        [TestMethod]
        public void BinaryCrossoverTest()
        {
            BinaryGenotype bg1 = new BinaryGenotype(new int[] { 0, 0, 0, 0 });
            BinaryGenotype bg2 = new BinaryGenotype(new int[] { 0, 1, 0, 1 });
            BinaryGenotype bg3 = new BinaryGenotype(new int[] { 0, 0, 1, 0 });
            BinaryGenotype bg4 = new BinaryGenotype(new int[] { 0, 0, 0, 1 });
            BinaryGenotype bg5 = new BinaryGenotype(new int[] { 1, 0, 0, 0 });
            BinaryGenotype bg6 = new BinaryGenotype(new int[] { 0, 1, 1, 0 });

            BinaryGenotype res = GeneticOperators.BitVector_OnePointCrossOverTesting(bg1, bg2, 2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.binaryVector);

            res = GeneticOperators.BitVector_OnePointCrossOverTesting(bg1, bg2, 2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.binaryVector);

            res = GeneticOperators.BitVector_OnePointCrossOverTesting(bg1, bg2, 3);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, res.binaryVector);

            res = GeneticOperators.BitVector_OnePointCrossOverTesting(bg2, bg3, 2);
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 0 }, res.binaryVector);

            res = GeneticOperators.BitVector_OnePointCrossOverTesting(bg5, bg6, 1);
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 0 }, res.binaryVector);
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
