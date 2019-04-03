namespace ImperialCommand.Models
{
    public class ScoutTrooper : Trooper
    {
        public ScoutTrooper()
        {
            this.Weapon = new DL44();
            this.Health = 50;
            this.Defense = 1;
        }
    }
}