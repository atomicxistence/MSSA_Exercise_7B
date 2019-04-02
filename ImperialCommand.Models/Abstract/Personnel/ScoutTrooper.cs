namespace ImperialCommand.Models
{
    public class ScoutTrooper : Trooper
    {
        public ScoutTrooper()
        {
            Weapon = new DL44();
            Health = 50;
            Defense = 1;
        }
    }
}