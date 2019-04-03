using System;

namespace ImperialCommand.Models
{
    public abstract class Walker : IVehicle, IAttack, ITarget
    {
        public IWeapon Weapon { get; protected set;}
        public int Speed { get; protected set;}
        public bool IsOperable => Health > 0;
        public int Health { get; protected set;}
        public int Defense { get; protected set;}

        public virtual void Move()
        {
            //TODO: add some sort of move method?
        }

        public virtual void Attack(ITarget target)
        {
            var aim = new Random().Next(1,6);
            var lethality = Weapon.DamageAmount * aim;

            target.TakeDamage(lethality);
        }

        public virtual void TakeDamage(int damageAmount)
        {
            var shields = new Random().Next(1, 4); 
            var impact = damageAmount - (shields * Defense);
            if(impact >= 0)
            {
                Health -= impact; 
            }
        }
    }
}