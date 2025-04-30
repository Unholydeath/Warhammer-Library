using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Weapon
    {
        public string Name { get; protected set; }
        public int Range { get; protected set; }
        public int Attacks { get; protected set; }
        public int AttackSkill { get; protected set; }
        public int Strength { get; protected set; }
        public int ArmorPierce { get; protected set; }
        public int Damage { get; protected set; }
        public List<WeaponAbility> WeaponAbilities { get; protected set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetRange(int range)
        {
            Range = range;
        }

        public void SetAttacks(int attacks)
        {
            Attacks = attacks;
        }

        public void SetAttackSkill(int attackSkill)
        {
            AttackSkill = attackSkill;
        }

        public void SetStrength(int strength)
        {
            Strength = strength;
        }

        public void SetArmorPierce(int armorPierce)
        {
            ArmorPierce = armorPierce;
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }

        public void AddWeaponAbility(WeaponAbility weaponAbility)
        {
            if (WeaponAbilities == null)
            {
                WeaponAbilities = new List<WeaponAbility>();
            }
            WeaponAbilities.Add(weaponAbility);
        }

        public void RemoveWeaponAbility(WeaponAbility weaponAbility)
        {
            if (WeaponAbilities != null)
            {
                WeaponAbilities.Remove(weaponAbility);
            }
        }

        public void SetWeaponAbilities(List<WeaponAbility> weaponAbilities)
        {
            WeaponAbilities = weaponAbilities;
        }

        public Weapon()
        {
            Name = "";
            Range = 0;
            Attacks = 0;
            AttackSkill = 0;
            Strength = 0;
            ArmorPierce = 0;
            Damage = 0;
            WeaponAbilities = new List<WeaponAbility>();

        }
    }
}
