using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    interface IAdultSelectionStrategy
    {
        List<Individual> adultSelection(List<Individual> adults, List<Individual> children);
    }
}
