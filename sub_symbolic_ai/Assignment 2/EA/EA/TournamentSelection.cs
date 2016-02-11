using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    class TournamentSelection : IParentSelectionStrategy
    {

        int numberOfSelections { get; set; }
        int groupSize { get; set; }
        double winningProbability { get; set; }
        Random r { get; }

        public TournamentSelection(int numberOfSelections, int groupSize, double winningProbability)
        {
            this.numberOfSelections = numberOfSelections;
            this.groupSize = groupSize;
            this.winningProbability = winningProbability;
            r = new Random();
        }

        public List<IPhenotype> selectParents(List<IPhenotype> candidates)
        {
            List<IPhenotype> winners = new List<IPhenotype>();

            while (winners.Count < this.numberOfSelections)
            {

                // Select K to participate in tournament
                List<IPhenotype> participants = createTournamentGroup(candidates);

                IPhenotype bestParticipant = participants.Aggregate((i1, i2) => i1.fitness > i2.fitness ? i1 : i2);
                participants.Remove(bestParticipant);

                // Choose best with probability 1 - winningProbability, 
                // or else choose randomly from remaining participants.
                if (r.NextDouble() < winningProbability)
                {
                    winners.Add(bestParticipant);
                }
                else
                {
                    winners.Add(participants[r.Next(0, participants.Count)]);
                }
            }


            return winners;
        }

        private List<IPhenotype> createTournamentGroup(List<IPhenotype> candidates)
        {
            List<IPhenotype> participants = new List<IPhenotype>();

            for (int i = 0; i < groupSize; i++)
            {
                participants.Add(candidates[r.Next(0, candidates.Count)]);
            }

            return participants;
        }
    }
}
