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
        public void SSCalculatorTest()
        {
            SSCalculator ssc = new SSCalculator(SSTypes.Global);

            SymbolIndividual si = new SymbolIndividual(new int[] { 0, 0, 1, 2, 2, 2 });
            SymbolDevelopment sb = new SymbolDevelopment();
            sb.DevelopGenotype(si);
            ssc.CalculateAndSetFitness(si);

            Assert.AreEqual(0.25, si.fitness);

        }

        [TestMethod]
        public void SSDuplicatesTest()
        {
            SSCalculator ssc = new SSCalculator(SSTypes.Global);


            // 1 Global duplication
            int[] pheno = new int[] { 0, 0, 1, 2, 2 };

            int res = ssc.GetViolations(pheno , 0);
            Assert.AreEqual(0, res);

            res = ssc.GetViolations(pheno, 1);
            Assert.AreEqual(0, res);

            res = ssc.GetViolations(pheno, 2);
            Assert.AreEqual(1, res);

            res = ssc.GetViolations(pheno, 3);
            Assert.AreEqual(0, res);


            // 
            pheno = new int[] { 0, 0, 0, 0, 0 };

            res = ssc.GetViolations(pheno, 0);
            Assert.AreEqual(3, res);

            res = ssc.GetViolations(pheno, 1);
            Assert.AreEqual(2, res);

            res = ssc.GetViolations(pheno, 2);
            Assert.AreEqual(1, res);

            res = ssc.GetViolations(pheno, 3);
            Assert.AreEqual(0, res);

            // 
            pheno = new int[] { 0, 0, 1, 2, 2, 2 };

            res = ssc.GetGlobalViolations(pheno);
            Assert.AreEqual(3, res);




        }

        [TestMethod]
        public void ListCloningTest()
        {
            List<Individual> list = new List<Individual>();
            for (int i = 0; i < 20; i++)
                list.Add(new BinaryIndividual(10));

            List<Individual> list2 = new List<Individual>(list);


            Assert.AreNotEqual(list, list2);
            CollectionAssert.AreEqual(list, list2);

            //List<Individual> list3 = new EA.EA().ClonePopulation(list);
        }

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
        public void TestLOLZ()
        {
            LOLZFitnessCalculator ofc = new LOLZFitnessCalculator(4);
            BinaryDevelopment bd = new BinaryDevelopment();

            Individual i = new BinaryIndividual(new int[] { 1,1,1,1,1,1});
            bd.DevelopGenotype(i);
            Assert.AreEqual(6, ofc.CalculateFitness(i));

            i = new BinaryIndividual(new int[] { 0, 0, 0, 0, 0, 0 });
            bd.DevelopGenotype(i);
            Assert.AreEqual(4, ofc.CalculateFitness(i));

            i = new BinaryIndividual(new int[] { 1, 1, 0, 1, 0, 1 });
            bd.DevelopGenotype(i);
            Assert.AreEqual(2, ofc.CalculateFitness(i));

            i = new BinaryIndividual(new int[] { 0, 0, 1, 0, 1, 1 });
            bd.DevelopGenotype(i);
            Assert.AreEqual(2, ofc.CalculateFitness(i));
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
