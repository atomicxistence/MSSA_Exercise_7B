using System;

namespace ImperialCommand.Models
{
    public class StormTrooper : Trooper
    {
        public StormTrooper()
        {
            Weapon = new E11();
            Health = 60;
            Defense = 2;
        }
    }
}