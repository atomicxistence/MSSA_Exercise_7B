namespace ImperialCommand.Models
{
    public interface IVehicle
    {
        public string Nomenclature { get;}
        public int StructuralIntegrity { get;}

        public void Repair(int amount);
    }
}