namespace ImperialCommand.Models
{
    public interface ITarget
    {
        int Defense { get;}
        void TakeDamage(int damageAmount);
    }
}