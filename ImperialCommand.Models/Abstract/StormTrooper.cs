namespace ImperialCommand.Models
{
    public class StormTrooper : IPersonnel, IAttack, ITarget
    {
        public IWeapon Weapon { get;}
        public bool Alive { get;}
        public int DamageAmount { get;}
        public int Defense { get;}

        public StormTrooper()
        {
            Weapon = new E11();
        }

        public void Attack(ITarget target)
        {
            target.TakeDamage(Weapon.Type, DamageAmount);
        }

        public void TakeDamage(WeaponType damageType, int damageAmount)
        {
            throw new System.NotImplementedException();
        }
    }
}