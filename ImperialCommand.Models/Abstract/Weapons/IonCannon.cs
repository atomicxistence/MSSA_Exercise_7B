using System.Timers;

namespace ImperialCommand.Models
{
    public class IonCannon : IWeapon
    {
        private int rateOfFire = 5;
        private Timer fireTimer;

        public bool ReadyToFire { get; private set;}
        public WeaponType Type => WeaponType.Mounted;
        public int DamageAmount => 30;

        public IonCannon()
        {
            fireTimer = new Timer(rateOfFire * 1000);
            fireTimer.AutoReset = false;
            fireTimer.Elapsed += (sender, args) => ReadyToFire = true;
            Reload();
        }

        public void Fire()
        {
            ReadyToFire = false;
            Reload();
        }

        public void Reload()
        {
           fireTimer.Start();
        }
    }
}