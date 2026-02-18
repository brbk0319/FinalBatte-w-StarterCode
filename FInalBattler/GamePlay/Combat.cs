using FinalBattler.Character;
using FinalBattler.Interfaces;
using System;

namespace FinalBattler.GamePlay
{
    public class Combat
    {
        private bool AllAlive = true;

        public Creations Fighter1;
        public Creations Fighter2;
        //int rounds?
        public Combat(Creations fighter1, Creations fighter2)
        {
            Fighter1 = fighter1;
            Fighter2 = fighter2;
        }
        public void Fight()
        //future update: TakeTurn, which can give a cooler action than just attack
        {
            Console.WriteLine($"\n\nTHE FIGHT BEGINS!!!\n{Fighter1.Name.ToUpper()} vs {Fighter2.Name.ToUpper()}");
            while (Fighter1.CurrentHealth > 0 && Fighter2.CurrentHealth > 0)
            {
                Fighter1.GiveDamage(Fighter2);
                if (Fighter1.CurrentHealth <= 0 || Fighter2.CurrentHealth <= 0)
                {
                    Console.WriteLine("Someone's dead."); DeclareWinner(); return;
                }

                Fighter2.GiveDamage(Fighter1);
                if (Fighter1.CurrentHealth <= 0 || Fighter2.CurrentHealth <= 0)
                {
                    Console.WriteLine("Someone's dead."); DeclareWinner(); return;
                }
            }
        }
        public bool CheckDead()
        {
            if (Fighter1.CurrentHealth <= 0 || Fighter2.CurrentHealth <= 0) { return false; }
            return true;
        }

        public void DeclareWinner()
        {
            if (Fighter1.CurrentHealth > Fighter2.CurrentHealth)
            {
                Console.WriteLine($"{Fighter2.Name.ToUpper()} is dead.\n{Fighter1.Name.ToUpper()} WINS!!!!");
            }
            else if (Fighter1.CurrentHealth < Fighter2.CurrentHealth)
            {
                Console.WriteLine($"{Fighter1.Name.ToUpper()} is dead.\n{Fighter2.Name.ToUpper()} WINS!!!!");
            }
        }
    }
}
