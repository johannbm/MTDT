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
        public void TournamentSelectionDiscardNone()
        {
            List<IPhenotype> adults = new List<IPhenotype>();

            for (int i  = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
            }

            TournamentSelection ts = new TournamentSelection(5, 0.0);
            ts.tournamentType = TournamentType.DiscardNone;
            List<IPhenotype> results = ts.selectParents(adults, 10);

            DebugPhenotypeList(results);

            Assert.AreEqual(results.Count, 10);
        }

        [TestMethod]
        public void TournamentSelectionDiscardWinner()
        {
            List<IPhenotype> adults = new List<IPhenotype>();

            for (int i = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
            }

            TournamentSelection ts = new TournamentSelection(5, 0.0);
            ts.tournamentType = TournamentType.DiscardWinner;
            List<IPhenotype> results = ts.selectParents(adults, 10);

            DebugPhenotypeList(results);
            Console.WriteLine(adults.Count);
            Assert.AreEqual(adults.Count, 20);
            Assert.AreEqual(results.Count, 10);
        }


        [TestMethod]
        public void RouletteTest()
        {
            List<IPhenotype> adults = new List<IPhenotype>();

            for (int i = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
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

            IPhenotype res = rw.spinWheel(0.01);
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
            List<IPhenotype> adults = new List<IPhenotype>();
            Dictionary<IPhenotype, int> occurances = new Dictionary<IPhenotype, int>();

            for (int i = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                FitnessProportionateSelection fps = new FitnessProportionateSelection();
                List<IPhenotype> res = fps.selectParents(adults, 5);

                foreach (IPhenotype p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach(KeyValuePair<IPhenotype, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }



        }

        [TestMethod]
        public void SigmaScaledFitnessTest()
        {
            List<IPhenotype> adults = new List<IPhenotype>();
            Dictionary<IPhenotype, int> occurances = new Dictionary<IPhenotype, int>();

            for (int i = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                SigmaScalingSelection sss = new SigmaScalingSelection();
                List<IPhenotype> res = sss.selectParents(adults, 5);

                foreach (IPhenotype p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach (KeyValuePair<IPhenotype, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }
        }

        [TestMethod]
        public void BoltzmannScaledFitnessTest()
        {
            List<IPhenotype> adults = new List<IPhenotype>();
            Dictionary<IPhenotype, int> occurances = new Dictionary<IPhenotype, int>();

            for (int i = 0; i < 20; i++)
            {
                adults.Add(new BinaryPhenotype(i));
                occurances.Add(adults[i], 0);
            }

            for (int i = 0; i < 50000; i++)
            {
                BoltzmannScalingSelection bss = new BoltzmannScalingSelection(10);
                List<IPhenotype> res = bss.selectParents(adults, 5);

                foreach (IPhenotype p in res)
                {
                    occurances[p] += 1;
                }

            }

            foreach (KeyValuePair<IPhenotype, int> entry in occurances)
            {
                Console.WriteLine(entry.Key.fitness + " : " + entry.Value);
            }
        }



        private void DebugPhenotypeList(List<IPhenotype> list)
        {
            foreach(BinaryPhenotype p in list)
                Console.WriteLine(p.fitness);
        }

    }
}
