using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class UnitComposition
    {
        public int UnitCount { get; init; }
        public int PointCost { get; init; }
        

        public UnitComposition(int unitCount, int points)
        {
            UnitCount = unitCount;
            PointCost = points;            
        }

    }
}
