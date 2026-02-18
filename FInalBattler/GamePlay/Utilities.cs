using FinalBattler.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBattler.GamePlay
{
    public class Utilities
    {
        public static void WelcomeHero(Hero hero)
        {
            Console.WriteLine($"Welcome {hero.Name}, the {hero.HeroClass.ToString()}");
        }
    }
}
