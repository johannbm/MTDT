﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public enum TournamentType{ DiscardAll, DiscardWinner, DiscardNone

    }

    public class TournamentSelection : ParentSelectionStrategy
    {

        int groupSize { get; set; }
        double winningProbability { get; set; }
        public TournamentType tournamentType { get; set; }
        Random r { get; }

        public TournamentSelection(int groupSize, double winningProbability)
        {
            this.groupSize = groupSize;
            this.winningProbability = winningProbability;
            r = new Random();
        }


        public override List<IPhenotype> selectParents(List<IPhenotype> candidates, int numberOfSelections)
        {
            List<IPhenotype> candidatesCopy = new List<IPhenotype>(candidates);
            List<IPhenotype> winners = new List<IPhenotype>();

            List<IPhenotype> participants = null;

            while (winners.Count < numberOfSelections)
            {

                // Select K to participate in tournament
                try
                {
                    participants = createTournamentGroup(candidatesCopy);
                    Console.WriteLine(participants.Count);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    return winners;
                }

                IPhenotype bestParticipant = participants.Aggregate((i1, i2) => i1.fitness > i2.fitness ? i1 : i2);


                switch (tournamentType)
                {
                    case TournamentType.DiscardWinner:
                        candidatesCopy.Remove(bestParticipant);
                        break;
                    case TournamentType.DiscardAll:
                        Console.WriteLine("BEFORE: " + candidatesCopy.Count);
                        candidatesCopy = candidatesCopy.Except(participants).ToList();
                        Console.WriteLine("After: " + candidatesCopy.Count);

                        break;
                }

                participants.Remove(bestParticipant);

                // Choose best with probability 1 - winningProbability, 
                // or else choose randomly from remaining participants.
                if (r.NextDouble() <= winningProbability)
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

