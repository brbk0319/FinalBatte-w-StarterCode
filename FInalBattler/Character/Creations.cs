using System.Security.Claims;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Creations : IDamageCalulator
    {
        public string Name { get; set; }
        public int Level { get; protected set; }
        public int CurrentHealth { get; protected set; }
        public int TotalHealth { get; protected set; }
        public int TotalPower { get; protected set; }
        public int TotalLuck { get; protected set; }

        public Creations() { }
        
        public void GiveDamage(Creations enemy, int extraDamage = 0)
        {
            Console.WriteLine($"{Name} does {TotalPower} damage!");
            enemy.TakeDamage(TotalPower + extraDamage);
        }
        public void TakeDamage(int damage)
        {
            if (damage >= CurrentHealth) { CurrentHealth = 0; }
            else { CurrentHealth -= damage; }

            Console.WriteLine($"{Name} takes {damage} damage\nCurrent health is {CurrentHealth}");
        }
    }
}
