namespace ImperialCommand.Models
{
    public abstract class Trooper : IPersonnel, IAttack, ITarget
    {
        public IWeapon Weapon { get;}
        public bool IsAlive { get { Health > 0;} }
        public int Health { get;}
        public int Defense { get;}

        public virtual void Attack(ITarget target)
        {
            var aim = new Random().Next(1,6);
            var lethality = Weapon.DamageAmount * aim;

            target.TakeDamage(lethality);
        }

        public virtual void TakeDamage(int damageAmount)
        {
            var dodge = new Random().Next(1, 10);
            if(dodge != 10)
            {   
                var impact = damageAmount - (dodge * Defense);
                if(impact >= 0)
                {
                    Health -= impact; 
                }
            }
        }
    }
}