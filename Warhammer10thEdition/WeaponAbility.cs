using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class WeaponAbility
    {
        public WeaponAbilityEnum WeaponAbilityEnum { get; protected set; }
        public int AbilityCount { get; protected set; }
        public int CriticalHitValue { get; protected set; }

        public void SetWeaponAbilityEnum(WeaponAbilityEnum weaponAbilityEnum)
        {
            WeaponAbilityEnum = weaponAbilityEnum;
        }

        public void SetAbilityCount(int abilityCount)
        {
            AbilityCount = abilityCount;
        }
        public void SetCriticalHitValue(int criticalHitValue)
        {
            CriticalHitValue = criticalHitValue;
        }

        public WeaponAbility()
        {
            WeaponAbilityEnum = WeaponAbilityEnum.NONE;
            AbilityCount = Constants.ABILITY_COUNT;
            CriticalHitValue = Constants.CRITICAL_HIT_VALUE;
        }
    }
}
