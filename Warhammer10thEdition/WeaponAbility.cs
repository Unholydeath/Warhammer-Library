using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class WeaponAbility
    {
        public WeaponAbilityEnum WeaponAbilityEnum { get; set; }
        public int AbilityCount { get; set; }

        public WeaponAbility(WeaponAbilityEnum weaponAbilityEnum, int abilityCount)
        {
            WeaponAbilityEnum = weaponAbilityEnum;
            AbilityCount = abilityCount;
        }
    }
}
