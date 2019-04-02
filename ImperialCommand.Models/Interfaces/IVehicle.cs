namespace ImperialCommand.Models
{
    public interface IVehicle
    {
        public IWeapon Weapon { get; }
        public int Speed { get; }
        public bool IsOperable { get; }

        public void Move();
    }
}