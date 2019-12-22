using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatienceShoppingPlatform.Migrations
{
    public partial class ShoppingItemsContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    RemovedBy = table.Column<string>(nullable: true),
                    DateRemoved = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DateRemoved", "Description", "Image", "ModifiedBy", "Name", "RemovedBy", "Status" },
                values: new object[] { 1, "Nondumiso Lunga", new DateTime(2019, 11, 26, 18, 4, 32, 763, DateTimeKind.Local).AddTicks(7050), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "V-Neck man t-shirt", null, "System Administrator", "Plain white summer T-shirt", null, "Instock" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DateRemoved", "Description", "Image", "ModifiedBy", "Name", "RemovedBy", "Status" },
                values: new object[] { 2, "Prince Lunga", new DateTime(2019, 10, 28, 18, 4, 32, 772, DateTimeKind.Local).AddTicks(2391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young boys blue jeans", null, " ", "Blue Jeams Short", " ", "Instock" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DateRemoved", "Description", "Image", "ModifiedBy", "Name", "RemovedBy", "Status" },
                values: new object[] { 3, "Prince Lunga", new DateTime(2019, 10, 18, 18, 4, 32, 772, DateTimeKind.Local).AddTicks(2518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young girls blue jeans", null, " ", "Blue Jeams Short skirrt", " ", "Instock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
