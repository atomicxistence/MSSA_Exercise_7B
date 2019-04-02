namespace ImperialCommand.Models
{
    public class MS4TwinCannon : IWeapon
    {
        private int rateOfFire = 2;
        private bool readyFire = true;
        private Timer fireTimer;

        public WeaponType Type => WeaponType.Mounted;
        public int DamageAmount => 15;

        public MS4TwinCannon()
        {
            fireTimer = new Timer(rateOfFire * 1000);
            fireTimer.AutoReset(false);
            fireTimer.Elapsed += () => ReadyToFire = true;
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