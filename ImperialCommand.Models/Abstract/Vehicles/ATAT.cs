namespace ImperialCommand.Models
{
    public class ATAT : Walker
    {
        public ATAT()
        {
            this.Speed = 5;
            this.Defense = 50;
            this.Health = 150;
            this.Weapon = new IonCannon();
        }
    }
}