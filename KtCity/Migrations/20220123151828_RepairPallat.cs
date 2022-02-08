using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class RepairPallat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rang",
                table: "Palats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rang",
                table: "Palats");
        }
    }
}
