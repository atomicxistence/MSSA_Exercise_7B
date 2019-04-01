namespace ImperialCommand.Models
{
    public abstract class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("The vehicle moves into position.");
        }

        public virtual void Attack()
        {
            Console.WriteLine("This vehicle performs fires it's weapons.");
        }
    }
}