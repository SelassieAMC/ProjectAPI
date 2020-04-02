using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Infraestructure.Persistence.Migrations
{
    public partial class tableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isVideo",
                table: "CatalogsMedia",
                newName: "IsVideo");

            migrationBuilder.RenameColumn(
                name: "isPhoto",
                table: "CatalogsMedia",
                newName: "IsPhoto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsVideo",
                table: "CatalogsMedia",
                newName: "isVideo");

            migrationBuilder.RenameColumn(
                name: "IsPhoto",
                table: "CatalogsMedia",
                newName: "isPhoto");
        }
    }
}
