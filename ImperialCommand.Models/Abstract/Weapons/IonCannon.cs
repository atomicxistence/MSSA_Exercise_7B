namespace ImperialCommand.Models
{
    public class IonCannon : IWeapon
    {
        public WeaponType Type => WeaponType.Mounted;
        public int DamageAmount => 30;

        public void Fire()
        {
            throw new System.NotImplementedException();
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}