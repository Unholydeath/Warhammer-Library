using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class UnitComposition
    {
        public int UnitCount { get; protected set; }
        public int PointCost { get; protected set; }
        
        public void SetUnitCount(int unitCount)
        {
            UnitCount = unitCount;
        }

        public void SetPointCost(int pointCost)
        {
            PointCost = pointCost;
        }

        public UnitComposition()
        {
            UnitCount = 0;
            PointCost = 0;
        }

    }
}
