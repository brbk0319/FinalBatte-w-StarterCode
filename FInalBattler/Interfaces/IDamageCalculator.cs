namespace FinalBattler.Interfaces
{
    public interface IDamageCalulator
    {
        void DisplayDamage(int damage);
        void GiveDamage(Character.Creations enemy);
        void TakeDamage(int damage);
    }
}
