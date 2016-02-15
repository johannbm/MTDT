using System;
using System.Collections.Generic;


namespace EA
{
    public class RouletteWheel
    {

        private List<Tuple<IPhenotype, double>> rouletteEntriesList;
        private double previousShare = 0;

        public RouletteWheel()
        {
            rouletteEntriesList = new List<Tuple<IPhenotype, double>>();
        }

        public void AddPhenotype(IPhenotype phenotype, double share)
        {
            double newShare = previousShare + share;
            rouletteEntriesList.Add(new Tuple<IPhenotype, double>(phenotype, newShare));
            previousShare = newShare;

            if (newShare > 1.0)
            {
                Console.WriteLine("Error: total share larger than 1.0");
            }

        }

        public IPhenotype spinWheel()
        {

            double choice = Utility.GetRandom().NextDouble();

            IPhenotype winner = null;

            for (int i = 0; i < rouletteEntriesList.Count; i++)
            {
                Tuple<IPhenotype, double> entry = rouletteEntriesList[i];
                if (entry.Item2 > choice)
                {
                    return entry.Item1;
                }
            }

            return winner;
        }

        // For testing.
        public IPhenotype spinWheel(double choice)
        {
            
            IPhenotype winner = null;

            for (int i = 0; i < rouletteEntriesList.Count; i++)
            {
                Tuple<IPhenotype, double> entry = rouletteEntriesList[i];
                if (entry.Item2 > choice)
                {
                    return entry.Item1;
                }
            }

            return winner;
        }

        public void DebugWheel()
        {
            foreach (Tuple<IPhenotype, double> entry in rouletteEntriesList)
            {
                Console.WriteLine(entry.Item2);
            }
        }




    }
}
