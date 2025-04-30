using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Transport
    {
        public int CarryCapacity { get; protected set; }
        public List<Unit> CarryUnitList { get; protected set; }

        public void SetCarryCapacity(int carryCapacity)
        {
            CarryCapacity = carryCapacity;
        }

        public void AddCarryUnit(Unit unit)
        {
            if (CarryUnitList == null)
            {
                CarryUnitList = new List<Unit>();
            }
            CarryUnitList.Add(unit);
        }

        public void RemoveCarryUnit(Unit unit)
        {
            if (CarryUnitList != null)
            {
                CarryUnitList.Remove(unit);
            }
        }

        public void SetCarryUnitList(List<Unit> carryUnitList)
        {
            CarryUnitList = carryUnitList;
        }
    }
}
