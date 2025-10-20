namespace ShipmentTracking.Server.Domain.Cargos
{
    public sealed partial class Cargo
    {
        public sealed record CargoInformation(
            CargoTypeEnum CargoType,
            decimal Weight
            );
    }
}
