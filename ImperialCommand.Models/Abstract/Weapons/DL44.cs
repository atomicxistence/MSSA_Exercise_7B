namespace ImperialCommand.Models
{
    public class DL44 : IWeapon
    {
        private const int ammoCapacity = 20;
        private int ammo;

        public WeaponType Type => WeaponType.Pistol;
        public int DamageAmount => 20;

        public DL44()
        {
            Reload();
        }

        public void Fire()
        {
            ammo -= 1;
        }

        public void Reload()
        {
            ammo = ammoCapacity;
        }
    }
}