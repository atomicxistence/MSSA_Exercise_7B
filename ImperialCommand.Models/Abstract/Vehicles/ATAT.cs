namespace ImperialCommand.Models
{
    public class ATAT : Walker
    {
        public ATAT()
        {
            Speed = 5;
            Defense = 50;
            Health = 150;
            Weapon = new IonCannon();
        }
    }
}