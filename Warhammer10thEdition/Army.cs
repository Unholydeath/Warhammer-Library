using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Army
    {
        public string Name { get; protected set; }
        public string ArmyRule { get; protected set; }
        public List<Unit> Units { get; protected set; }
        public List<Detachment> Detachments { get; protected set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetArmyRule(string armyRule)
        {
            ArmyRule = armyRule;
        }

        public void AddUnit(Unit unit)
        {
            if (Units == null)
            {
                Units = new List<Unit>();
            }

            Units.Add(unit);
        }

        public void RemoveUnit(Unit unit)
        {
            if (Units != null)
            {
                Units.Remove(unit);
            }
        }

        public void SetUnits(List<Unit> units)
        {
            Units = units;
        }   

        public void AddDetachment(Detachment detachment)
        {
            if (Detachments == null)
            {
                Detachments = new List<Detachment>();
            }
            Detachments.Add(detachment);
        }

        public void RemoveDetachment(Detachment detachment)
        {
            if (Detachments != null)
            {
                Detachments.Remove(detachment);
            }
        }

        public void SetDetachments(List<Detachment> detachments)
        {
            Detachments = detachments;
        }   

        public Army()
        {
            Name = "";
            ArmyRule = "";
            Units = new List<Unit>();
            Detachments = new List<Detachment>();
        }
    }
}
