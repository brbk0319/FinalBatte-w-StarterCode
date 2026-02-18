namespace FinalBattler.Interfaces
{
    public interface IDamageCalulator
    {
        void GiveDamage(Character.Creations enemy, int extraDamage);
        void TakeDamage(int damage);
    }
}
