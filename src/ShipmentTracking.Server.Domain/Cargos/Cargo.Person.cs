namespace ShipmentTracking.Server.Domain.Cargos
{
    public sealed partial class Cargo
    {
        public sealed record Person(
            string FirstName,
            string LastName,
            string TcNumarasi,
            string PhoneNumber,
            string Email
            );
    }
}
