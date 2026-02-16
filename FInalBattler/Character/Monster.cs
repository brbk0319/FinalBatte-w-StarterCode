using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Monster : Creations, IDamageCalulator
    {
        public Monster(string name)
        {
            Name = name;
        }

    }
}
