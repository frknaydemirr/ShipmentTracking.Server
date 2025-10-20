using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShipmentTracking.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kargolarım",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sender_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_TcNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_TcNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress_Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress_FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress_StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress_Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoInformations_CargoType = table.Column<int>(type: "int", nullable: false),
                    CargoInformations_Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeleteUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargolarım", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kargolarım");
        }
    }
}
