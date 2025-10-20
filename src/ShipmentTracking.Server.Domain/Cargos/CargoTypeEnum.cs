using Ardalis.SmartEnum;

namespace ShipmentTracking.Server.Domain.Cargos
{
    public sealed partial class Cargo
    {
        public sealed class CargoTypeEnum : SmartEnum<CargoTypeEnum>
        {

            public static CargoTypeEnum Paket = new("Paket", 0);
            public static CargoTypeEnum Zarf = new("Zarf", 1);
            public static CargoTypeEnum Koli = new("Koli", 2);

            public CargoTypeEnum(string name, int value) : base(name, value)
            {

            }
        }
    }
}
