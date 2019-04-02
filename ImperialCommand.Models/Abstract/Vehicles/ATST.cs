namespace ImperialCommand.Models
{
    public class ATST : Walker
    {
        public ATST()
        {
            Speed = 10;
            Defense = 25;
            Health = 100;
            Weapon = new MS4TwinCannon();
        }
    }
}