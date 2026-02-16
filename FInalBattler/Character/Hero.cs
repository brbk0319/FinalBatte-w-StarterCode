using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero, IDamageCalulator
    {
        public int ExperienceRemaining { get; set; }
        public int Mana { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0; TotalHealth = 1; TotalLuck = 1; TotalPower = 1;
            CurrentHealth = 1; TotalPower = 1; TotalLuck = 1; Mana = 1; ExperienceRemaining = 1;
            CombatClass = GetClass();
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }
        public Hero(string name)
        {
            Name = name;
            Level = 0; TotalHealth = 1; TotalLuck = 1; TotalPower = 1;
            CurrentHealth = 1; TotalPower = 1; TotalLuck = 1; Mana = 1; ExperienceRemaining = 1;
            CombatClass = GetClass();
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }


        public void DisplayStats(bool showTotalStats = false)
        //The bool will be used to decide whether to show total stats or the natural stats(no equipment).
        {
            if (!showTotalStats)
            {
                Console.WriteLine($"{Name.ToUpper()} Status:\n   Level: {Level}\n   Total Health: {CurrentHealth}/{TotalHealth}\n   Power: {TotalPower}\n   Luck: {TotalLuck}\n   Mana: {Mana}\n   ExperienceRemaining: {ExperienceRemaining}");
            }
            else
            {
                Console.WriteLine($"{Name.ToUpper()} Status:\n   Level: {Level}\n   Total Health: {CurrentHealth}/{TotalHealth}\n   Power: {TotalPower}\n   Luck: {TotalLuck}\n   Mana: {Mana}\n   ExperienceRemaining: {ExperienceRemaining}");
                //how to do total stats?
            }
        }
        public void LevelUp()
        {
            Random rng = new Random();
            switch ( CombatClass )
            {
                case CombatClass.None:
                    CurrentHealth += rng.Next(1, 5);
                    TotalPower += rng.Next(1, 2);
                    TotalLuck += rng.Next(1, 2);
                    break;
                case CombatClass.Warrior:
                    CurrentHealth += rng.Next(10, 20);
                    TotalPower += rng.Next(1, 3);
                    TotalLuck += rng.Next(1, 3);
                    break;
                case CombatClass.Wizard:
                    CurrentHealth += rng.Next(1, 15);
                    TotalPower += rng.Next(3, 5);
                    TotalLuck += rng.Next(1, 15);
                    break; 
                case CombatClass.Rogue:
                    CurrentHealth += rng.Next(1, 15);
                    TotalPower += rng.Next(1, 3);
                    TotalLuck += rng.Next(3-5);
                    break;
            }
        }
        public void CalculateTotals()
        {
            //natural stats + stats from equipment
        }

    }
}
