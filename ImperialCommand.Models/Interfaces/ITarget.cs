namespace ImperialCommand.Models
{
    public interface ITarget
    {
        public int Defense { get;}

        public void TakeDamage(WeaponType damageType, int damageAmount);
    }
}