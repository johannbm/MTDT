using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EA;

namespace EATesting
{
    [TestClass]
    public class ParentSelectionTests
    {

        [TestMethod]
        public void CopyTest()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] secondNumbers = (int[])numbers.Clone();

            secondNumbers[3] = 1023231;

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            foreach (int i in secondNumbers)
            {
                Console.WriteLine(i);
            }
        }



        [TestMethod]
        public void TournamentSelectionDiscardNone()
        {
            List<Individual> adults = new List<Individual>();

            for (int i  = 0; i < 20; i++)
            {
                //adults.Add(new BinaryIndividual((i));
            }

            TournamentSelection ts = new TournamentSelection(5, 0.0);
            ts.tournamentType = TournamentType.DiscardNone;
            List<Individual> results = ts.selectParents(adults, 10);

            DebugPhenotypeList(results);

            Assert.AreEqual(results.Count, 10);
        }

        [TestMethod]
        public void TournamentSelectionDiscardWinner()
        {
            List<Individual> adults = new List<Individual>();

            for (int i = 0; i < 20; i++)
            {
                //adults.Add(new BinaryIndividual((double)i));
            }

            TournamentSelection ts = new TournamentSelection(5, 0.0);
            ts.tournamentType = TournamentType.DiscardWinner;
            List<Individual> results = ts.selectParents(adults, 10);

            DebugPhenotypeList(results);
            Console.WriteLine(adults.Count);
            Assert.AreEqual(adults.Count, 20);
            Assert.AreEqual(results.Count, 10);
        }


        [TestMethod]
        public void RouletteTest()
        {
            List<Individual> adults = new List<Individual>();

            for (int i = 0; i < 20; i++)
            {
                //adults.Add(new BinaryIndividual((double)i));
            }

            RouletteWheel rw = new RouletteWheel();

            rw.AddPhenotype(adults[0], 0.1);
            rw.AddPhenotype(adults[1], 0.1);
            rw.AddPhenotype(adults[2], 0.1);
            rw.AddPhenotype(adults[3], 0.1);
            rw.AddPhenotype(adults[4], 0.1);
            rw.AddPhenotype(adults[5], 0.1);
            rw.AddPhenotype(adults[6], 0.1);
            rw.AddPhenotype(adults[7], 0.1);
            rw.AddPhenotype(adults[8], 0.1);
            rw.AddPhenotype(adults[9], 0.1);

            Individual res = rw.spinWheel(0.01);
            Assert.AreEqual(adults[0], res);
            res = rw.spinWheel(0.10001);
            Assert.AreEqual(adults[1], res);
            res = rw.spinWheel(0.20001);
            Assert.AreEqual(adults[2], res);
            res = rw.spinWheel(0.30001);
            Assert.AreEqual(adults[3], res);
            res = rw.spinWheel(0.40001);
            Assert.AreEqual(adults[4], res);
            res = rw.spinWheel(0.50001);
            Assert.AreEqual(adults[5], res);
            res = rw.spinWheel(0.60001);
            Assert.AreEqual(adults[6], res);
            res = rw.spinWheel(0.70001);
            Assert.AreEqual(adults[7], res);
            res = rw.spinWheel(0.80001);
            Assert.AreEqual(adults[8], res);
            res = rw.spinWheel(0.90001);
            Assert.AreEqual(adults[9], res);

            res = rw.spinWheel(0.05);
            Assert.AreEqual(adults[0], res);
            res = rw.spinWheel(0.199);
            Assert.AreEqual(adults[1], res);
            res = rw.spinWheel(0.267);
            Assert.AreEqual(adults[2], res);
            res = rw.spinWheel(0.39999);
            Assert.AreEqual(adults[3], res);
            res = rw.spinWheel(0.42);
            Assert.AreEqual(adults[4], res);
            res = rw.spinWheel(0.543);
            Assert.AreEqual(adults[5], res);
            res = rw.spinWheel(0.6678);
            Assert.AreEqual(adults[6], res);
            res = rw.spinWheel(0.799999);
            Assert.AreEqual(adults[7], res);
            res = rw.spinWheel(0.800000000000000000001);
            Assert.AreEqual(adults[8], res);
            res = rw.spinWheel(0.999);
            Assert.AreEqual(adults[9], res);

        }

        [TestMethod]
        public void FitnessProportionateTest()
        {
            List<Individual> adults = new List<Individual>();
            Dictionary<Individual, int> occurances = new Dictionary<Individual, int>();

            for (int i = 0; i < 20; i++)
            {
                Individual ind = new BinaryIndividual(0);
                ind.fitness = i;
                adults.Add(ind);
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                FitnessProportionateSelection fps = new FitnessProportionateSelection();
                List<Individual> res = fps.selectParents(adults, 5);

                foreach (Individual p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach(KeyValuePair<Individual, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }



        }

        [TestMethod]
        public void SigmaScaledFitnessTest()
        {
            List<Individual> adults = new List<Individual>();
            Dictionary<Individual, int> occurances = new Dictionary<Individual, int>();

            for (int i = 0; i < 20; i++)
            {
                Individual ind = new BinaryIndividual(10);
                ind.fitness = 5;
                adults.Add(ind);
                //adults.Add(new BinaryIndividual((double)i));
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                SigmaScalingSelection sss = new SigmaScalingSelection();
                List<Individual> res = sss.selectParents(adults, 5);

                foreach (Individual p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach (KeyValuePair<Individual, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }
        }

        [TestMethod]
        public void BoltzmannScaledFitnessTest()
        {
            List<Individual> adults = new List<Individual>();
            Dictionary<Individual, int> occurances = new Dictionary<Individual, int>();

            for (int i = 0; i < 20; i++)
            {
                //adults.Add(new BinaryIndividual((double)i));
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                BoltzmannScalingSelection bss = new BoltzmannScalingSelection(10);
                List<Individual> res = bss.selectParents(adults, 5);

                foreach (Individual p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach (KeyValuePair<Individual, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }
        }



        private void DebugPhenotypeList(List<Individual> list)
        {
            foreach(BinaryIndividual p in list)
                Console.WriteLine(p.fitness);
        }

    }
}
