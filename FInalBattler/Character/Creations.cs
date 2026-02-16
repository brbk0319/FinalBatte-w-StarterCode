using System.Security.Claims;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Creations : IDamageCalulator
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int CurrentHealth { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }

        private bool FirstTurn { get; set; }

        public Creations() { }

        public CombatClass GetClass()
        {
            CombatClass creationsClass;
            while (true)
            {
                Console.WriteLine("Pick your Character's Class.\n   1. None\n   2. Warrior\n   3. Wizard\n    4. Rogue");
                string answer = Console.ReadLine() ?? "";
                if (Enum.TryParse(answer, out creationsClass))
                {
                    return creationsClass;
                }
                else { Console.WriteLine("Haha, try again player.\n"); }
            }
        }
        
        public void DisplayDamage(int damage)
        {
            //$"{name} takes {damage} damage
            //$"current health is {health}"
        }
        public void GiveDamage(Creations enemy)
        {
            enemy.TakeDamage(TotalPower);
        }
        public void TakeDamage(int damage)
        {
            //health -= damage
            //unless damage is more than health
            //in which case health = 0
            DisplayDamage(damage);
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
