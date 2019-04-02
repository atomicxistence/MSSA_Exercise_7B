namespace ImperialCommand.Models
{
    public virtual class Walker : IVehicle, IAttack, ITarget
    {
        public IWeapon Weapon { get; }
        public int Speed { get; }
        public bool IsOperable { get{ Health > 0;} }
        public int Health { get; }
        public int Defense { get; }

        public virtual void Move()
        {
            throw new System.NotImplementedException();
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