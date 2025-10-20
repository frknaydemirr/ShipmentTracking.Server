using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipmentTracking.Server.Domain.Cargos;

namespace ShipmentTracking.Server.Infrastructure.Configurations
{
    //value objectleri mapliyoruz -> configurationla:
    internal sealed class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.OwnsOne(p => p.Receiver); //alıcıAdı alıcıSoyadı gibi yerleştirir 
            builder.OwnsOne(p => p.Sender);
            builder.OwnsOne(p => p.DeliveryAddress);
            builder.OwnsOne(p => p.CargoInformations,builder=>
            {
                builder.Property(p => p.CargoType).HasConversion(type => type.Value,value=>
                Cargo.CargoTypeEnum.FromValue(value));//enum mapleyebiliyoruz
            }); 


        }
    }
}
