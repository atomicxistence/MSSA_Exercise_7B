namespace ImperialCommand.Models
{
    public interface ITarget
    {
        public int Defense { get;}
        public void TakeDamage(int damageAmount);
    }
}