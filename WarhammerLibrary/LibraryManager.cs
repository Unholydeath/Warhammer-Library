using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Warhammer10thEdition;

namespace WarhammerLibrary
{
    public class LibraryManager
    {
        private Dictionary<string, Army> armyDictionary;
        //private FileReader reader;
        private Database database;

        private void PrintIntro()
        {
            System.Console.WriteLine("-----------Warhammer Library--------");
            System.Console.WriteLine();
            System.Console.WriteLine("Welcome to the Warhammer Library!");
            System.Console.WriteLine("I will now load the contents for 10th edition");
        }

        private void PrintFiles()
        {
            System.Console.WriteLine("Here's the current contents of the library:");
            System.Console.WriteLine("--------------ARMIES--------------");
            System.Console.WriteLine("There are currently " + armyDictionary.Count + " armies in the library");
            foreach (Army army in armyDictionary.Values)
            {
                System.Console.WriteLine("Army named: " + army.Name + " which has " + army.Detachments.Count + " detachments and " + army.Units.Count + " units in it.");
                System.Console.WriteLine("Army rule: " + army.ArmyRule);
                System.Console.WriteLine("--------------DETACHMENTS--------------");
                foreach (Detachment detachment in army.Detachments)
                {
                    System.Console.WriteLine("Detachment name: " + detachment.Name);
                    System.Console.WriteLine("Detachment rule: " + detachment.Rule);
                    System.Console.WriteLine("--------------STRATAGEMS--------------");
                    foreach (Stratagem stratagem in detachment.Stratagems)
                    {
                        System.Console.WriteLine("Stratagem name: " + stratagem.Name);
                        System.Console.WriteLine("Stratagem when to use: " + stratagem.WhenToUse);
                        System.Console.WriteLine("Stratagem eligible targets: " + stratagem.EligibleTargets);
                        System.Console.WriteLine("Stratagem effect: " + stratagem.Effect);
                        System.Console.WriteLine("Stratagem point cost: " + stratagem.PointCost);
                    }
                    System.Console.WriteLine("--------------ENHANCEMENTS--------------");
                    foreach (Enhancement enhancement in detachment.Enhancements)
                    {
                        System.Console.WriteLine("Enhancement name: " + enhancement.Name);
                        System.Console.WriteLine("Enhancement eligible users: " + enhancement.EligibleUsers);
                        System.Console.WriteLine("Enhancement ability: " + enhancement.Ability);
                        System.Console.WriteLine("Enhancement point cost: " + enhancement.PointCost);
                    }
                }
                System.Console.WriteLine("--------------UNITS--------------");
                foreach (Unit unit in army.Units)
                {
                    System.Console.WriteLine("Unit name: " + unit.Name);
                    System.Console.WriteLine("Unit movement: " + unit.Movement);
                    System.Console.WriteLine("Unit toughness: " + unit.Toughness);
                    System.Console.WriteLine("Unit armor save: " + unit.ArmorSave);
                    System.Console.WriteLine("Unit wounds: " + unit.Wounds);
                    System.Console.WriteLine("Unit leadership: " + unit.Leadership);
                    System.Console.WriteLine("Unit objective control: " + unit.ObjectiveControl);
                    System.Console.WriteLine("Unit invulnerable save: " + unit.InvulnerableSave);

                    System.Console.WriteLine("--------------RANGED WEAPONS--------------");
                    foreach (Weapon weapon in unit.RangedWeapons)
                    {
                        System.Console.WriteLine("Ranged weapon name: " + weapon.Name);
                        System.Console.WriteLine("Ranged weapon range: " + weapon.Range);
                        System.Console.WriteLine("Ranged weapon attacks: " + weapon.Attacks);
                        System.Console.WriteLine("Ranged weapon strength: " + weapon.Strength);
                        System.Console.WriteLine("Ranged weapon AP: " + weapon.ArmorPierce);
                        System.Console.WriteLine("Ranged weapon damage: " + weapon.Damage);

                        System.Console.WriteLine("--------------RANGED WEAPON ABILITIES--------------");
                        foreach (WeaponAbility ability in weapon.WeaponAbilities)
                        {
                            System.Console.WriteLine("Ranged weapon ability enum: " + ability.WeaponAbilityEnum);
                            System.Console.WriteLine("Ranged weapon ability count: " + ability.AbilityCount);
                            System.Console.WriteLine("Ranged weapon ability critical hit value: " + ability.CriticalHitValue);
                        }
                    }

                    System.Console.WriteLine("--------------MELEE WEAPONS--------------");
                    foreach (Weapon weapon in unit.MeleeWeapons)
                    {
                        System.Console.WriteLine("Melee weapon name: " + weapon.Name);
                        System.Console.WriteLine("Melee weapon attacks: " + weapon.Attacks);
                        System.Console.WriteLine("Melee weapon strength: " + weapon.Strength);
                        System.Console.WriteLine("Melee weapon AP: " + weapon.ArmorPierce);
                        System.Console.WriteLine("Melee weapon damage: " + weapon.Damage);

                        System.Console.WriteLine("--------------MELEE WEAPON ABILITIES--------------");
                        foreach (WeaponAbility ability in weapon.WeaponAbilities)
                        {
                            System.Console.WriteLine("Melee weapon ability enum: " + ability.WeaponAbilityEnum);
                            System.Console.WriteLine("Melee weapon ability count: " + ability.AbilityCount);
                            System.Console.WriteLine("Melee weapon ability critical hit value: " + ability.CriticalHitValue);
                        }
                    }

                    System.Console.WriteLine("--------------UNIT ABILITIES--------------");
                    foreach (string ability in unit.Abilities)
                    {
                        System.Console.WriteLine("Unit ability: " + ability);
                    }
                    
                    System.Console.WriteLine("--------------UNIT COMPOSITIONS--------------");
                    foreach (UnitComposition unitComposition in unit.UnitCompositions)
                    {
                        System.Console.WriteLine("Unit composition count: " + unitComposition.UnitCount);
                        System.Console.WriteLine("Unit composition point cost: " + unitComposition.PointCost);
                    }

                    System.Console.WriteLine("--------------UNIT KEYWORDS--------------");
                    foreach (KeyWordEnum keyWord in unit.KeyWords)
                    {
                        System.Console.WriteLine("Unit keyword: " + keyWord);
                    }
                }
            }
        }
        
        public LibraryManager()
        {
            //reader = new FileReader();
            //armyDictionary = reader.GetFiles();

            database = new Database();
            armyDictionary = database.GetDictionary();
        }

        public void StartLibrary()
        {
            PrintIntro();
            PrintFiles();
            //reader.SaveFiles(armyDictionary);

        }
    }
}
