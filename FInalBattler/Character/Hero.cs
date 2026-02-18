using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;
using System.Threading;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {

        public int ExperienceRemaining { get; protected set; }
        public int Mana { get; protected set; }
        public int Power { get; protected set; }
        public int Luck { get; protected set; }
        public CombatClass HeroClass { get; set; }
        public List<Item> Items { get; protected set; }
        public List<Skill> Skills { get; protected set; }
        public List<Spell> Spells { get; protected set; }
        public List<Equipment> Equipment { get; protected set; }



        public Hero()
        {
            Name = GetName();
            HeroClass = GetClass();
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }

        public Hero(string name = "Unknown")
        {
            Name = name;
            HeroClass = GetClass();
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }
        public Hero(string name, CombatClass heroClass)
        {
            Name = name;
            HeroClass = heroClass;
            SetStats(HeroClass);
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }

        public Hero(CombatClass heroClass)
        {
            Name = GetName();
            HeroClass = heroClass;
            SetStats(HeroClass);
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }

        public string GetName()
        {
            string name;
            Console.WriteLine("What's your Hero's name?");
            name = Console.ReadLine() ?? "";
            return name;
        }
        public CombatClass GetClass()
        {
            CombatClass creationsClass;
            while (true)
            {
                Console.WriteLine("Pick your Character's Class.\n   1. None\n   2. Warrior\n   3. Wizard\n   4. Rogue");
                string answer = Console.ReadLine() ?? "";
                if (Enum.TryParse(answer, out creationsClass))
                {
                    SetStats(creationsClass);
                    return creationsClass;
                }
                else { Console.WriteLine("Haha, try again player.\n"); }
            }
        }
        protected void SetStats(CombatClass heroClass)
        {
            switch (heroClass)
            {
                case CombatClass.None:
                    Level = 0; TotalHealth = 3; CurrentHealth = 3; Power = 1; TotalPower = Power + 1;
                    Luck = 1; Mana = 0; ExperienceRemaining = 7;
                    break;
                case CombatClass.Warrior:
                    Level = 0; TotalHealth = 4; CurrentHealth = 4;  Power = 2; TotalPower = Power + 1;
                    Luck = 1; Mana = 0; ExperienceRemaining = 5;
                    break;
                case CombatClass.Wizard:
                    Level = 0; TotalHealth = 3; CurrentHealth = 3; Power = 5; TotalPower = Power + 1;
                    Luck = 2; Mana = 1; ExperienceRemaining = 5;
                    break;
                case CombatClass.Rogue:
                    Level = 0; TotalHealth = 3; CurrentHealth = 3; Power = 2; TotalPower = Power + 1;
                    Luck = 3; Mana = 0; ExperienceRemaining = 5;
                    break;
            }
        }


        public void DisplayStats(bool showTotalStats = false)
        //The bool will be used to decide whether to show total stats or the natural stats(no equipment).
        //total stats = natural stats + equipment modifiers
        {
            if (!showTotalStats)
            {
                Console.WriteLine($"{Name.ToUpper()} Stats:" +
                    $"\n   Level: {Level}\n   Health: {CurrentHealth}/{TotalHealth}" +
                    $"\n   Power: {Power}\n   Luck: {Luck}\n   Mana: {Mana}" +
                    $"\n   ExperienceRemaining: {ExperienceRemaining}");
            }
            else
            {
                CalculateTotals();
                Console.WriteLine($"{Name.ToUpper()} Total Stats:" +
                    $"\n   Level: {Level}\n   Total Health: {CurrentHealth}/{TotalHealth}" +
                    $"\n   Power: {TotalPower}\n   Luck: {TotalLuck}\n   Mana: {Mana}" +
                    $"\n   ExperienceRemaining: {ExperienceRemaining}");
            }
        }
        public void LevelUp()        
        //could switch this out for polymorphism? subclasses of hero?
        {
            Random rng = new Random();
            switch (HeroClass)
            {
                case CombatClass.None:
                    TotalHealth += rng.Next(1, 5);
                    TotalPower += rng.Next(1, 2);
                    TotalLuck += rng.Next(1, 2);
                    break;
                case CombatClass.Warrior:
                    TotalHealth += rng.Next(10, 20);
                    TotalPower += rng.Next(1, 3);
                    TotalLuck += rng.Next(1, 3);
                    break;
                case CombatClass.Wizard:
                    TotalHealth += rng.Next(1, 15);
                    TotalPower += rng.Next(3, 5);
                    TotalLuck += rng.Next(1, 15);
                    break;
                case CombatClass.Rogue:
                    TotalHealth += rng.Next(1, 15);
                    TotalPower += rng.Next(1, 3);
                    TotalLuck += rng.Next(3 - 5);
                    break;
            }
        }
        public void CalculateTotals() //unfinished
        {
            //natural stats + stats from equipment
            //Total = default (regular) + equipment power/luck/health
        }

    }
    public class Warrior : Hero 
    {
        public Warrior(CombatClass heroClass = CombatClass.Warrior) : base(heroClass) { }
        public Warrior(string name, CombatClass heroClass = CombatClass.Warrior) : base(name, heroClass) { }

        public void WieldSword()
        {
            //something from list items, cool dialogue thing, call "GiveDamage()"
        }
    }

    public class Wizard : Hero
    {
        public Wizard(CombatClass heroClass = CombatClass.Wizard) : base(heroClass) { }
        public Wizard(string name, CombatClass heroClass = CombatClass.Wizard) : base(name, heroClass) { }
        public void CastSpell()
        {
            //something from list spells, cool dialogue, call GiveDamage();
        }
    }

    public class Rogue : Hero
    {
        public Rogue(CombatClass heroClass = CombatClass.Rogue) : base(heroClass) { }
        public Rogue(string name, CombatClass heroClass = CombatClass.Rogue) : base(name, heroClass) { }

        public void ShootBow()
        {
            //use item Bow, cool dialogue, call GiveDamage();
        }
    }
        public enum CombatClass
        {
            None = 1,
            Warrior,
            Wizard,
            Rogue
        }

}
