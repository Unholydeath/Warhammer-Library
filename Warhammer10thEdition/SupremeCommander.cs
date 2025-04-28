using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class SupremeCommander : Leader
    {
        public SupremeCommander(string name, int movement, int toughness, int armorSave, int wounds, int leadership, int objectiveControl, int invulnerableSave, List<Weapon> rangedWeapons, List<Weapon> meleeWeapons, List<string> abilities, List<UnitComposition> unitCompositions, List<KeyWordEnum> keyWords) : base(name, movement, toughness, armorSave, wounds, leadership, objectiveControl, invulnerableSave, rangedWeapons, meleeWeapons, abilities, unitCompositions, keyWords)
        {
        }

        public List<string> CommanderAbilities { get; init; }
    }
}
