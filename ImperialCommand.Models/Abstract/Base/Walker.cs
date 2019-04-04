using System;

namespace ImperialCommand.Models
{
    public abstract class Walker : IVehicle, IAttack, ITarget
    {
        private int velocity;

        public IWeapon Weapon { get; protected set;}
        public int Speed { get; protected set;}
        public bool IsOperable => Health > 0;
        public int Health { get; protected set;}
        public int Defense { get; protected set;}

        public virtual void Move(Direction direction)
        {
            velocity = (int)direction * Speed;
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