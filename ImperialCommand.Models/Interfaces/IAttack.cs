namespace ImperialCommand.Models
{
    public interface IAttack
    {
        public int DamageAmount { get;}

        public void Attack(ITarget target);
    }
}