using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Warhammer10thEdition;

namespace WarhammerLibrary
{
    public class FileReader
    {
        private string fileLocation = "C:\\Users\\thebo\\Documents\\WarhammerLibraryFiles\\SavedLibrary.json";

        public Dictionary<string, Army> GetFiles()
        {
            Dictionary<string, Army> armyDictionary = new Dictionary<string, Army>();

            //Read a section of the file to get an army's data
            string armyName = "Thousand Sons";
            string armyRule = "Magic Pew Pew";
            
            List<Detachment> detachments = new List<Detachment>();
            string detachmentName = "Cult of Magic";
            string detachmentRule = "Shoot Magic Bolts";
            List<Stratagem> detachmentStratagems = new List<Stratagem>();
            List<Enhancement> detachmentEnhancements = new List<Enhancement>();

            string stratagemName = "Ensorcelled Infusion";
            string stratagemWhenToUse = "Your Shooting Phase";
            string stratagemEligibleTargets = "One of your thousand son psykers";
            string stratagemEffect = "Make your guys better";
            int stratagemCost = 1;
            Stratagem detachmentStratagem = new Stratagem(stratagemName, stratagemWhenToUse, stratagemEligibleTargets, stratagemEffect, stratagemCost);
            detachmentStratagems.Add(detachmentStratagem);

            string enhancementName = "Umbralefic Crystal";
            string enhancementEligibleUsers = "Characters in army";
            string enhancementAbility = "Deep strike unit";
            int enhancementCost = 20;
            Enhancement detachmentEnhancement = new Enhancement(enhancementName, enhancementEligibleUsers, enhancementAbility, enhancementCost);
            detachmentEnhancements.Add(detachmentEnhancement);

            Detachment detachment = new Detachment(detachmentName, detachmentRule, detachmentStratagems, detachmentEnhancements);
            detachments.Add(detachment);
            //Add detachments based on file

            List<Unit> unitList = new List<Unit>();
            //Add Units to the list based on file

            string unitName = "Rubric Marine";
            int unitMovement = 5;
            int unitToughness = 4;
            int unitArmorSave = 3;
            int unitWounds = 2;
            int unitLeadership = 6;
            int unitObjectiveControl = 2;
            int unitInvulnerableSave = 5;
            List<Weapon> unitRangedWeaponList = new List<Weapon>();

            string unitRangedWeaponName = "Inferno Boltgun";
            int unitRangedWeaponRange = 24;
            int unitRangedWeaponAttacks = 2;
            int unitRangedWeaponAttackSkill = 3;
            int unitRagedWeaponStrength = 4;
            int unitRangedWeaponArmorPierce = 1;
            int unitRangedWeaponDamage = 1;
            List<WeaponAbility> unitRangedWeaponAbilities = new List<WeaponAbility>();
            WeaponAbilityEnum unitRangedWeaponAbilityType = WeaponAbilityEnum.LETHAL_HITS;
            int unitRangedWeaponAbilityCount = 1;
            WeaponAbility unitRangedWeaponAbility = new WeaponAbility(unitRangedWeaponAbilityType, unitRangedWeaponAbilityCount);
            unitRangedWeaponAbilities.Add(unitRangedWeaponAbility);
            Weapon unitRangedWeapon = new Weapon(unitRangedWeaponName, unitRangedWeaponRange, unitRangedWeaponAttacks, unitRangedWeaponAttackSkill, unitRagedWeaponStrength, unitRangedWeaponArmorPierce, unitRangedWeaponDamage, unitRangedWeaponAbilities);
            
            List<Weapon> unitMeleeWeaponList = new List<Weapon>();

            string unitMeleeWeaponName = "Punch";
            int unitMeleeWeaponRange = 0;
            int unitMeleeWeaponAttacks = 2;
            int unitMeleeWeaponAttackSkill = 3;
            int unitMeleeeaponStrength = 4;
            int unitMeleeWeaponArmorPierce = 0;
            int unitMeleeWeaponDamage = 1;
            List<WeaponAbility> unitMeleeWeaponAbilities = new List<WeaponAbility>();
            WeaponAbilityEnum unitMeleeWeaponAbilityType = WeaponAbilityEnum.LETHAL_HITS;
            int unitMeleeWeaponAbilityCount = 1;
            WeaponAbility unitMeleeWeaponAbility = new WeaponAbility(unitMeleeWeaponAbilityType, unitMeleeWeaponAbilityCount);
            unitMeleeWeaponAbilities.Add(unitMeleeWeaponAbility);
            Weapon unitMeleeWeapon = new Weapon(unitMeleeWeaponName, unitMeleeWeaponRange, unitMeleeWeaponAttacks, unitMeleeWeaponAttackSkill, unitMeleeeaponStrength, unitMeleeWeaponArmorPierce, unitMeleeWeaponDamage, unitMeleeWeaponAbilities);

            List<string> unitAbilities = new List<string>();
            string unitAbility = "Stronger on objectives";
            unitAbilities.Add(unitAbility);

            List<UnitComposition> unitCompositions = new List<UnitComposition>();
            int unitCompositionNum1UnitCount = 5;
            int unitCompositionNum1PointCount = 110;
            UnitComposition unitCompositionNum1 = new UnitComposition(unitCompositionNum1UnitCount, unitCompositionNum1PointCount);
            int unitCompositionNum2UnitCount = 10;
            int unitCompositionNum2PointCount = 220;
            UnitComposition unitCompositionNum2 = new UnitComposition(unitCompositionNum2UnitCount, unitCompositionNum2PointCount);
            unitCompositions.Add(unitCompositionNum1);
            unitCompositions.Add(unitCompositionNum2);

            List<KeyWordEnum> unitKeyWords = new List<KeyWordEnum>();
            unitKeyWords.Add(KeyWordEnum.PSYKER);
            unitKeyWords.Add(KeyWordEnum.INFANTRY);
            unitKeyWords.Add(KeyWordEnum.TZEENTCH);
            unitKeyWords.Add(KeyWordEnum.RUBRIC_MARINES);
            unitKeyWords.Add(KeyWordEnum.BATTLELINE);

            Unit unit = new Unit(unitName, unitMovement, unitToughness, unitArmorSave, unitWounds, unitLeadership, unitObjectiveControl, unitInvulnerableSave, unitRangedWeaponList, unitMeleeWeaponList, unitAbilities, unitCompositions, unitKeyWords);
            unitList.Add(unit);

            Army army = new Army(armyName, armyRule, unitList, detachments);
            armyDictionary.Add(armyName, army);
            //End of loop, go back as needed

            return armyDictionary;
        }

        public void SaveFiles(Dictionary<string, Army> armyDictionary)
        {                       
            string json = JsonSerializer.Serialize(armyDictionary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileLocation, json);

            Console.WriteLine("Library saved to JSON file.");
        }
    }
}
