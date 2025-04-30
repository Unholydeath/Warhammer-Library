using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Warhammer10thEdition;

namespace WarhammerLibrary
{
    internal class Database
    {
        //private string fileLocation = "C:\\Users\\thebo\\Documents\\WarhammerLibraryFiles\\SavedLibrary.json";

        public Dictionary<string, Army> GetDictionary()
        {
            Dictionary<string, Army> armyDictionary = new Dictionary<string, Army>();

            Army army = new Army();

            //Read a section of the file to get an army's data
            string armyName = "Thousand Sons";
            string armyRule = "Magic Pew Pew";

            army.SetName(armyName);
            army.SetArmyRule(armyRule);

            //Add a detachment to the army
            List<Detachment> armyDetachments = new List<Detachment>();

            Detachment detachment = new Detachment();
            string detachmentName = "Cult of Magic";
            string detachmentRule = "Shoot Magic Bolts";

            detachment.SetName(detachmentName);
            detachment.SetRule(detachmentRule);

            List<Stratagem> detachmentStratagems = new List<Stratagem>();
            List<Enhancement> detachmentEnhancements = new List<Enhancement>();

            Stratagem detachmentStratagem = new Stratagem();
            string stratagemName = "Ensorcelled Infusion";
            string stratagemWhenToUse = "Your Shooting Phase";
            string stratagemEligibleTargets = "One of your thousand son psykers";
            string stratagemEffect = "Make your guys better";
            int stratagemCost = 1;

            detachmentStratagem.SetName(stratagemName);
            detachmentStratagem.SetWhenToUse(stratagemWhenToUse);
            detachmentStratagem.SetEligibleTargets(stratagemEligibleTargets);
            detachmentStratagem.SetEffect(stratagemEffect);
            detachmentStratagem.SetPointCost(stratagemCost);

            detachmentStratagems.Add(detachmentStratagem);
            detachment.SetStratagems(detachmentStratagems);

            Enhancement detachmentEnhancement = new Enhancement();
            string enhancementName = "Umbralefic Crystal";
            string enhancementEligibleUsers = "Characters in army";
            string enhancementAbility = "Deep strike unit";
            int enhancementCost = 20;

            detachmentEnhancement.SetName(enhancementName);
            detachmentEnhancement.SetEligibleUsers(enhancementEligibleUsers);
            detachmentEnhancement.SetAbility(enhancementAbility);
            detachmentEnhancement.SetPointCost(enhancementCost);

            detachmentEnhancements.Add(detachmentEnhancement);
            detachment.SetEnhancements(detachmentEnhancements);

            armyDetachments.Add(detachment);
            army.SetDetachments(armyDetachments);

            //Add Units to the army

            List<Unit> unitList = new List<Unit>();

            Unit unit = new Unit();

            string unitName = "Rubric Marine";
            int unitMovement = 5;
            int unitToughness = 4;
            int unitArmorSave = 3;
            int unitWounds = 2;
            int unitLeadership = 6;
            int unitObjectiveControl = 2;
            int unitInvulnerableSave = 5;

            unit.SetName(unitName);
            unit.SetMovement(unitMovement);
            unit.SetToughness(unitToughness);
            unit.SetArmorSave(unitArmorSave);
            unit.SetWounds(unitWounds);
            unit.SetLeadership(unitLeadership);
            unit.SetObjectiveControl(unitObjectiveControl);
            unit.SetInvulnerableSave(unitInvulnerableSave);

            List<Weapon> unitRangedWeaponList = new List<Weapon>();

            Weapon unitRangedWeapon = new Weapon();

            string unitRangedWeaponName = "Inferno Boltgun";
            int unitRangedWeaponRange = 24;
            int unitRangedWeaponAttacks = 2;
            int unitRangedWeaponAttackSkill = 3;
            int unitRagedWeaponStrength = 4;
            int unitRangedWeaponArmorPierce = 1;
            int unitRangedWeaponDamage = 1;

            unitRangedWeapon.SetName(unitRangedWeaponName);
            unitRangedWeapon.SetRange(unitRangedWeaponRange);
            unitRangedWeapon.SetAttacks(unitRangedWeaponAttacks);
            unitRangedWeapon.SetAttackSkill(unitRangedWeaponAttackSkill);
            unitRangedWeapon.SetStrength(unitRagedWeaponStrength);
            unitRangedWeapon.SetArmorPierce(unitRangedWeaponArmorPierce);
            unitRangedWeapon.SetDamage(unitRangedWeaponDamage);

            List<WeaponAbility> unitRangedWeaponAbilities = new List<WeaponAbility>();
            WeaponAbility unitRangedWeaponAbility = new WeaponAbility();

            WeaponAbilityEnum unitRangedWeaponAbilityType = WeaponAbilityEnum.LETHAL_HITS;
            unitRangedWeaponAbility.SetWeaponAbilityEnum(unitRangedWeaponAbilityType);

            unitRangedWeaponAbilities.Add(unitRangedWeaponAbility);            
            
            unitRangedWeapon.SetWeaponAbilities(unitRangedWeaponAbilities);
            unitRangedWeaponList.Add(unitRangedWeapon);
            unit.SetRangedWeapons(unitRangedWeaponList);

            List<Weapon> unitMeleeWeaponList = new List<Weapon>();
            Weapon unitMeleeWeapon = new Weapon();

            string unitMeleeWeaponName = "Punch";
            int unitMeleeWeaponRange = 0;
            int unitMeleeWeaponAttacks = 2;
            int unitMeleeWeaponAttackSkill = 3;
            int unitMeleeeaponStrength = 4;
            int unitMeleeWeaponArmorPierce = 0;
            int unitMeleeWeaponDamage = 1;

            unitMeleeWeapon.SetName(unitMeleeWeaponName);
            unitMeleeWeapon.SetRange(unitMeleeWeaponRange);
            unitMeleeWeapon.SetAttacks(unitMeleeWeaponAttacks);
            unitMeleeWeapon.SetAttackSkill(unitMeleeWeaponAttackSkill);
            unitMeleeWeapon.SetStrength(unitMeleeeaponStrength);
            unitMeleeWeapon.SetArmorPierce(unitMeleeWeaponArmorPierce);
            unitMeleeWeapon.SetDamage(unitMeleeWeaponDamage);

            List<WeaponAbility> unitMeleeWeaponAbilities = new List<WeaponAbility>();
            WeaponAbility unitMeleeWeaponAbility = new WeaponAbility();

            WeaponAbilityEnum unitMeleeWeaponAbilityType = WeaponAbilityEnum.LETHAL_HITS;

            unitMeleeWeaponAbility.SetWeaponAbilityEnum(unitMeleeWeaponAbilityType);

            unitMeleeWeaponAbilities.Add(unitMeleeWeaponAbility);

            unitMeleeWeapon.SetWeaponAbilities(unitMeleeWeaponAbilities);
            unitMeleeWeaponList.Add(unitMeleeWeapon);
            unit.SetMeleeWeapons(unitMeleeWeaponList);

            List<string> unitAbilities = new List<string>();
            string unitAbility = "Stronger on objectives";
            unitAbilities.Add(unitAbility);
            unit.SetAbilities(unitAbilities);

            List<UnitComposition> unitCompositions = new List<UnitComposition>();

            UnitComposition unitCompositionNum1 = new UnitComposition();

            int unitCompositionNum1UnitCount = 5;
            int unitCompositionNum1PointCost = 110;

            unitCompositionNum1.SetUnitCount(unitCompositionNum1UnitCount);
            unitCompositionNum1.SetPointCost(unitCompositionNum1PointCost);

            UnitComposition unitCompositionNum2 = new UnitComposition();

            int unitCompositionNum2UnitCount = 10;
            int unitCompositionNum2PointCost = 220;

            unitCompositionNum2.SetUnitCount(unitCompositionNum2UnitCount);
            unitCompositionNum2.SetPointCost(unitCompositionNum2PointCost);

            unitCompositions.Add(unitCompositionNum1);
            unitCompositions.Add(unitCompositionNum2);

            unit.SetUnitCompositions(unitCompositions);

            List<KeyWordEnum> unitKeyWords = new List<KeyWordEnum>();
            unitKeyWords.Add(KeyWordEnum.PSYKER);
            unitKeyWords.Add(KeyWordEnum.INFANTRY);
            unitKeyWords.Add(KeyWordEnum.TZEENTCH);
            unitKeyWords.Add(KeyWordEnum.RUBRIC_MARINES);
            unitKeyWords.Add(KeyWordEnum.BATTLELINE);

            unit.SetKeyWords(unitKeyWords);

            unitList.Add(unit);
            army.SetUnits(unitList);

            armyDictionary.Add(armyName, army);
            //End of loop, go back as needed

            return armyDictionary;
        }

        /*public void SaveFiles(Dictionary<string, Army> armyDictionary)
        {
            string json = JsonSerializer.Serialize(armyDictionary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileLocation, json);

            Console.WriteLine("Library saved to JSON file.");
        }*/

    }
}
