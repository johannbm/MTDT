using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public class FullGenerationalReplacement : IAdultSelectionStrategy
    {
        public List<IPhenotype> adultSelection(List<IPhenotype> adults, List<IPhenotype> children)
        {
            return children;
        }
    }
}
