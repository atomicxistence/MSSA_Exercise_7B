namespace ImperialCommand.Models
{
    public interface IVehicle
    {
        IWeapon Weapon { get; }
        int Speed { get; }
        bool IsOperable { get; }

        void Move(Direction direction);
    }
}