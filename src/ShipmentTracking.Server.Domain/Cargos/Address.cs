namespace ShipmentTracking.Server.Domain.Cargos
{
    public sealed partial class Cargo
    {
        public sealed record Address(
            string City,
            string Town,
            string FullAddress,
            string StreetName,
            string Neighborhood
            );
    }
}
