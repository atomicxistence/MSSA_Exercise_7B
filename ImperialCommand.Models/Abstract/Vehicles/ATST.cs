namespace ImperialCommand.Models
{
    public class ATST : Walker
    {
        public ATST()
        {
            this.Speed = 10;
            this.Defense = 25;
            this.Health = 100;
            this.Weapon = new MS4TwinCannon();
        }
    }
}