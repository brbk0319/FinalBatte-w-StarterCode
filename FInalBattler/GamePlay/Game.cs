using FinalBattler.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBattler.GamePlay
{
    public class Game
    {
        public Hero Player1;
        public Hero Player2;
        public Game() { }

        public void Start()
        {
            Console.WriteLine("WELCOME TO THE GAME");

            Player1 = GetPlayer();
            Player2 = new Hero("Bob", CombatClass.Rogue);

            Utilities.WelcomeHero(Player1);
            Utilities.WelcomeHero(Player2);

            Combat firstFight = new Combat(Player1, Player2);
            firstFight.Fight();

            Console.WriteLine("\n\nThanks for playing!");
        }

        public Hero GetPlayer()
        {
            return new Hero();
        }
    }
}
