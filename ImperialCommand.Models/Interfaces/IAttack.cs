namespace ImperialCommand.Models
{
    public interface IAttack
    {
        int Health { get;}
        void Attack(ITarget target);
    }
}