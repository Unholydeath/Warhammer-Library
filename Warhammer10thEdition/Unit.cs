using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Unit
    {
        public string Name { get; protected set; }
        public int Movement { get; protected set; }
        public int Toughness { get; protected set; }
        public int ArmorSave { get; protected set; }
        public int Wounds { get; protected set; }
        public int Leadership { get; protected set; }
        public int ObjectiveControl {  get; protected set; }
        public int InvulnerableSave { get; protected set; }
        public List<Weapon> RangedWeapons { get; protected set; }
        public List<Weapon> MeleeWeapons { get; protected set; }
        public List<string> Abilities { get; protected set; }
        public List<UnitComposition> UnitCompositions { get; protected set; }
        public List<KeyWordEnum> KeyWords { get; protected set; }

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
