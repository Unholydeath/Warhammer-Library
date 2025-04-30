using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class SupremeCommander : Leader
    {

        public List<string> CommanderAbilities { get; protected set; }

        public void AddCommanderAbility(string commanderAbility)
        {
            if (CommanderAbilities == null)
            {
                CommanderAbilities = new List<string>();
            }
            CommanderAbilities.Add(commanderAbility);
        }

        public void RemoveCommanderAbility(string commanderAbility)
        {
            if (CommanderAbilities != null)
            {
                CommanderAbilities.Remove(commanderAbility);
            }
        }

        public void SetCommanderAbilities(List<string> commanderAbilities)
        {
            CommanderAbilities = commanderAbilities;
        }

        public SupremeCommander()
        {
            CommanderAbilities = new List<string>();
        }
    }
}
