using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Weapon
    {
        public string Name { get; init; }
        public int Range { get; init; }
        public int Attacks { get; init; }
        public int AttackSkill { get; init; }
        public int Strength { get; init; }
        public int ArmorPierce { get; init; }
        public int Damage { get; init; }
        public List<WeaponAbility> WeaponAbilities { get; init; }

        public Weapon(string name, int range, int attacks, int attackSkill, int strength, int armorPierce, int damage, List<WeaponAbility> weaponAbilities)
        {
            Name = name;
            Range = range;
            Attacks = attacks;
            AttackSkill = attackSkill;
            Strength = strength;
            ArmorPierce = armorPierce;
            Damage = damage;
            WeaponAbilities = weaponAbilities;
        }
    }
}
