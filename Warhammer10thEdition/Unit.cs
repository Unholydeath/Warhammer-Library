using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Unit
    {
        public string Name { get; init; }
        public int Movement { get; init; }
        public int Toughness { get; init; }
        public int ArmorSave { get; init; }
        public int Wounds { get; init; }
        public int Leadership { get; init; }
        public int ObjectiveControl {  get; init; }
        public int InvulnerableSave { get; init; }
        public List<Weapon> RangedWeapons { get; init; }
        public List<Weapon> MeleeWeapons { get; init; }
        public List<string> Abilities { get; init; }
        public List<UnitComposition> UnitCompositions { get; init; }
        public List<KeyWordEnum> KeyWords { get; init; }

        public Unit (string name, int movement, int toughness, int armorSave, int wounds, int leadership, int objectiveControl, int invulnerableSave, List<Weapon> rangedWeapons, List<Weapon> meleeWeapons, List<string> abilities, List<UnitComposition> unitCompositions, List<KeyWordEnum> keyWords)
        {
            Name = name;
            Movement = movement;
            Toughness = toughness;
            ArmorSave = armorSave;
            Wounds = wounds;
            Leadership = leadership;
            ObjectiveControl = objectiveControl;
            InvulnerableSave = invulnerableSave;
            RangedWeapons = rangedWeapons;
            MeleeWeapons = meleeWeapons;
            Abilities = abilities;
            UnitCompositions = unitCompositions;
            KeyWords = keyWords;
        }
    }
}
