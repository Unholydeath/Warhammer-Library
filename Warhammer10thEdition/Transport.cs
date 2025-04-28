using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Transport
    {
        public int CarryCapacity { get; init; }
        public List<Unit> CarryUnitList { get; init; }
    }
}
