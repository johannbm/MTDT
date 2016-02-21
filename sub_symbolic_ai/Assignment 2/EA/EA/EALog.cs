using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class EALog
    {
        private static int IDCounter = 0;

        public int ID { get; set; }
        public int numberOfGens { get; set; }
        public double time { get; set; }
        public string phenotype { get; set; }
        public List<GenerationLog> generationLog { get; set; }

        public EALog()
        {
            this.ID = ++IDCounter;
            generationLog = new List<GenerationLog>();
        }

        public void AddGenerationLog(GenerationLog gl)
        {
            generationLog.Add(gl);
        }



    }

    public class GenerationLog
    {
        public int generation { get; set; }
        public double bestFitness { get; set; }
        public double avgFitness { get; set; }
        public double std { get; set; }
        public string bestPhenotype { get; set; }
    }
}
