using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EA;

namespace EATesting
{
    [TestClass]
    public class FitnessTest
    {

        [TestMethod]
        public void TestCloning()
        {
            Individual i = new BinaryIndividual(new int[] { 1, 1, 1 });
            Individual i2 = i.Clone();
            new BinaryGeneticOperator().Mutate(i2, 1.0);

            Console.WriteLine(i.ToString());
            Console.WriteLine(i2.ToString());

        }

        [TestMethod]
        public void TestOneMax()
        {
            OneMaxFitnessCalculator ofc = new OneMaxFitnessCalculator(new int[] { 1, 1, 1 });
            Individual bi = new BinaryIndividual(new int[] { 1,1,1});
            BinaryDevelopment bd = new BinaryDevelopment();
            bd.DevelopGenotype(bi);

            

            Assert.AreEqual(ofc.CalculateFitness(bi), 3);

            ofc = new OneMaxFitnessCalculator(new int[] { 1, 1, 1 });
            bi = new BinaryIndividual(new int[] { 0, 0, 0 });
            bd.DevelopGenotype(bi);

            Assert.AreEqual(ofc.CalculateFitness(bi), 0);

            ofc = new OneMaxFitnessCalculator(new int[] { 0, 0, 1 });
            bi = new BinaryIndividual(new int[] { 1, 1, 1 });
            bd.DevelopGenotype(bi);

            Assert.AreEqual(ofc.CalculateFitness(bi), 1);

            ofc = new OneMaxFitnessCalculator(new int[] { 0, 0, 1 });
            bi = new BinaryIndividual(new int[] { 0, 0, 1 });
            bd.DevelopGenotype(bi);

            Assert.AreEqual(ofc.CalculateFitness(bi), 3);
        }
    }
}
