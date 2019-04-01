namespace ImperialCommand.Models
{
    public class E11 : IWeapon
    {
        private int _ammoCapacity = 30;
        private int _ammo;

        public WeaponType Type { get;}
        public int DamageAmount { get;}

        public E11()
        {
            Type = WeaponType.Rifle;
            DamageAmount = 10;
            Reload();
        }

        public void Reload()
        {
            _ammo = _ammoCapacity;
        }
    }
}