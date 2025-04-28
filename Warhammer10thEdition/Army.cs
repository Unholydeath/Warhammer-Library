using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Army
    {
        public string Name { get; init; }
        public string ArmyRule { get; init; }
        public List<Unit> Units { get; init; }
        public List<Detachment> Detachments { get; init; }

        public Army(string name, string armyRule, List<Unit> units, List<Detachment> detachments)
        {
            Name = name;
            ArmyRule = armyRule;
            Units = units;
            Detachments = detachments;
        }
    }
}
