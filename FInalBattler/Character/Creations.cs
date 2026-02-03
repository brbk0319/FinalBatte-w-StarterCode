using System.Security.Claims;

namespace FinalBattler.Character
{
    public class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }

        public Creations() { }

        public CombatClass GetClass()
        {
            CombatClass creationsClass;
            while (true)
            {
                Console.WriteLine("Pick your Hero's Class.\n   1. None\n   2. Warrior\n   3. Wizard\n    4. Rogue");
                string answer = Console.ReadLine() ?? "";
                if (Enum.TryParse(answer, out creationsClass))
                {
                    return creationsClass;
                }
                else { Console.WriteLine("Haha, try again player.\n"); }
            }
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
