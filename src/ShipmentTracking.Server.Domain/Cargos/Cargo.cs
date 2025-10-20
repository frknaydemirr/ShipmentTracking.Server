using ShipmentTracking.Server.Domain.Abstractions;

namespace ShipmentTracking.Server.Domain.Cargos
{
    public sealed partial class Cargo : Entity
    {
      public Person Sender { get; set; }=default!;

     public Person Receiver { get; set; }=default!;

    public Address DeliveryAddress { get; set; }=default!;

    public  CargoInformation CargoInformations { get; set; }=default!;
    }
}
