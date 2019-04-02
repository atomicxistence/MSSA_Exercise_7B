namespace ImperialCommand.Models
{
    public class E11 : IWeapon
    {
        private const int ammoCapacity = 100;
        private int ammo;

        public WeaponType Type => WeaponType.Rifle;
        public int DamageAmount => 6;

        public E11()
        {
            Reload();
        }

        public void Fire()
        {
            ammo -= 3;
        }

        public void Reload()
        {
            ammo = ammoCapacity;
        }
    }
}