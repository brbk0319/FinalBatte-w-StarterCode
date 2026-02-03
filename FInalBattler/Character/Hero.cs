using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0; Health = 1; Power = 1; Luck = 1; Mana = 1; ExperienceRemaining = 1;
            CombatClass = GetClass();
        }

        public void DisplayStats(bool showTotalStats = false)
        //The bool will be used to decide whether to show total stats or the natural stats(no equipment).
        {
            if (!showTotalStats)
            {

            }
            else
            {

            }
        }
        public void LevelUp()
        {



            /* 
                None
                Warrior
                Wizard
                Rogue 
            */


        }
        public void CalculateTotals()
        {
            //natural stats + stats from equipment
        }
    }
}
