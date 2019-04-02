namespace ImperialCommand.Models
{
    public interface IAttack
    {
        public int Health { get;}
        public void Attack(ITarget target);
    }
}