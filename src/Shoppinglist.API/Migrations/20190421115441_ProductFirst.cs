using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace Shoppinglist.API.Migrations
{
    public partial class ProductFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    QuantityInPackage = table.Column<short>(nullable: false),
                    UnitOfMeasurement = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "QuantityInPackage", "UnitOfMeasurement" },
                values: new object[] { 100, "Fruits and Vegetables", (short)0, (byte)0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "QuantityInPackage", "UnitOfMeasurement" },
                values: new object[] { 101, "Dairy", (short)0, (byte)0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
