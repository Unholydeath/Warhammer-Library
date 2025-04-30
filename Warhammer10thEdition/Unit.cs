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

        public void SetName (string name)
        {
            Name = name;
        }

        public void SetMovement (int movement)
        {
            Movement = movement;
        }

        public void SetToughness(int toughness)
        {
            Toughness = toughness;
        }

        public void SetArmorSave(int armorSave)
        {
            ArmorSave = armorSave;
        }

        public void SetWounds(int wounds)
        {
            Wounds = wounds;
        }

        public void SetLeadership(int leadership)
        {
            Leadership = leadership;
        }

        public void SetObjectiveControl(int objectiveControl)
        {
            ObjectiveControl = objectiveControl;
        }

        public void SetInvulnerableSave(int invulnerableSave)
        {
            InvulnerableSave = invulnerableSave;
        }

        public void AddRangedWeapon(Weapon rangedWeapon)
        {
            if (RangedWeapons == null)
            {
                RangedWeapons = new List<Weapon>();
            }

            RangedWeapons.Add(rangedWeapon);
        }   

        public void RemoveRangedWeapon(Weapon rangedWeapon)
        {
            if (RangedWeapons != null)
            {
                RangedWeapons.Remove(rangedWeapon);
            }
        }

        public void SetRangedWeapons(List<Weapon> rangedWeapons)
        {
            RangedWeapons = rangedWeapons;
        }

        public void AddMeleeWeapon(Weapon meleeWeapon)
        {
            if (MeleeWeapons == null)
            {
                MeleeWeapons = new List<Weapon>();
            }

            MeleeWeapons.Add(meleeWeapon);
        }

        public void RemoveMeleeWeapon(Weapon meleeWeapon)
        {
            if (MeleeWeapons != null)
            {
                MeleeWeapons.Remove(meleeWeapon);
            }
        }

        public void SetMeleeWeapons(List<Weapon> meleeWeapons)
        {
            MeleeWeapons = meleeWeapons;
        }

        public void AddAbility(string ability)
        {
            Abilities.Add(ability);
        }

        public void RemoveAbility(string ability)
        {
            if (Abilities != null)
            {
                Abilities.Remove(ability);
            }
        }

        public void SetAbilities(List<string> abilities)
        {
            if (Abilities == null)
            {
                Abilities = new List<string>();
            }

            Abilities = abilities;
        }

        public void AddUnitComposition(UnitComposition unitComposition)
        {
            if (UnitCompositions == null)
            {
                UnitCompositions = new List<UnitComposition>();
            }
            UnitCompositions.Add(unitComposition);
        }

        public void RemoveUnitComposition(UnitComposition unitComposition)
        {
            if (UnitCompositions != null)
            {
                UnitCompositions.Remove(unitComposition);
            }
        }

        public void SetUnitCompositions(List<UnitComposition> unitCompositions)
        {
            if (UnitCompositions == null)
            {
                UnitCompositions = new List<UnitComposition>();
            }
            UnitCompositions = unitCompositions;
        }

        public void AddKeyWord(KeyWordEnum keyWord)
        {
            if (KeyWords == null)
            {
                KeyWords = new List<KeyWordEnum>();
            }
            KeyWords.Add(keyWord);
        }

        public void RemoveKeyWord(KeyWordEnum keyWord)
        {
            if (KeyWords != null)
            {
                KeyWords.Remove(keyWord);
            }
        }

        public void SetKeyWords(List<KeyWordEnum> keyWords)
        {
            if (KeyWords == null)
            {
                KeyWords = new List<KeyWordEnum>();
            }
            KeyWords = keyWords;
        }

        public Unit()
        {
            Name = string.Empty;
            Movement = 0;
            Toughness = 0;
            ArmorSave = 0;
            Wounds = 0;
            Leadership = 0;
            ObjectiveControl = 0;
            InvulnerableSave = 0;
            RangedWeapons = new List<Weapon>();
            MeleeWeapons = new List<Weapon>();
            Abilities = new List<string>();
            UnitCompositions = new List<UnitComposition>();
            KeyWords = new List<KeyWordEnum>();
        }
    }
}
