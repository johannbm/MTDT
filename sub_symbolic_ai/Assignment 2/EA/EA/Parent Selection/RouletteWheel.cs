using System;
using System.Collections.Generic;


namespace EA
{
    public class RouletteWheel
    {

        private List<Tuple<Individual, double>> rouletteEntriesList;
        private double previousShare = 0;

        public RouletteWheel()
        {
            rouletteEntriesList = new List<Tuple<Individual, double>>();
        }

        public void AddPhenotype(Individual phenotype, double share)
        {
            double newShare = previousShare + share;
            rouletteEntriesList.Add(new Tuple<Individual, double>(phenotype, newShare));
            previousShare = newShare;

            if (newShare > 1.01)
            {
                Console.WriteLine("Error: total share larger than 1.0 : " + newShare);
            }

        }

        public Individual spinWheel()
        {

            double choice = Utility.GetRandom().NextDouble();

            Individual winner = null;

            for (int i = 0; i < rouletteEntriesList.Count; i++)
            {
                Tuple<Individual, double> entry = rouletteEntriesList[i];
                if (entry.Item2 > choice)
                {
                    return entry.Item1;
                }
            }

            if (winner == null)
                Console.WriteLine("no winner");

            return winner;
        }

        // For testing.
        public Individual spinWheel(double choice)
        {

            Individual winner = null;

            for (int i = 0; i < rouletteEntriesList.Count; i++)
            {
                Tuple<Individual, double> entry = rouletteEntriesList[i];
                if (entry.Item2 > choice)
                {
                    return entry.Item1;
                }
            }

            return winner;
        }

        public void DebugWheel()
        {
            foreach (Tuple<Individual, double> entry in rouletteEntriesList)
            {
                Console.WriteLine(entry.Item2);
            }
        }




    }
}
