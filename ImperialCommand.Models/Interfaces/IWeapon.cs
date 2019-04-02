namespace ImperialCommand.Models
{
    public interface IWeapon
    {
        public WeaponType Type { get;}
        public int DamageAmount { get;}

        public void Fire();
        public void Reload();
    }
}