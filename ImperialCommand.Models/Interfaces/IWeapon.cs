namespace ImperialCommand.Models
{
    public interface IWeapon
    {
        WeaponType Type { get;}
        int DamageAmount { get;}

        void Fire();
        void Reload();
    }
}