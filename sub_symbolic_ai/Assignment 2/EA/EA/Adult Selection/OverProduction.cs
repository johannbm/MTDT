﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class OverProduction : IAdultSelectionStrategy
    {
        public List<Individual> adultSelection(List<Individual> adults, List<Individual> children)
        {
            int populationSize = adults.Count;

            if (children.Count <= populationSize)
            {
                return children;
            }
            else
            {
                // Return best adultPoolSize best children.
                return  (from p in children
                         orderby p.fitness descending
                         select p).Take(populationSize).ToList();
            }

        }
    }
}
