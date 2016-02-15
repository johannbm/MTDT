using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA
{
    public interface IGenotype
    {
        IPhenotype developedPhenotype { get; set; }
        T CreateRandomGenotypes<T>();
    }
}
