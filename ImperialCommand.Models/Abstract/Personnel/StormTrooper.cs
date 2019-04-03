using System;

namespace ImperialCommand.Models
{
    public class StormTrooper : Trooper
    {
        public StormTrooper()
        {
            this.Weapon = new E11();
            this.Health = 60;
            this.Defense = 2;
        }
    }
}