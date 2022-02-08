using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class repjdg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Judges_Palats_Palataid",
                table: "Judges");

            migrationBuilder.RenameColumn(
                name: "Palataid",
                table: "Judges",
                newName: "Positionid");

            migrationBuilder.RenameIndex(
                name: "IX_Judges_Palataid",
                table: "Judges",
                newName: "IX_Judges_Positionid");

            migrationBuilder.AddForeignKey(
                name: "FK_Judges_Palats_Positionid",
                table: "Judges",
                column: "Positionid",
                principalTable: "Palats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Judges_Palats_Positionid",
                table: "Judges");

            migrationBuilder.RenameColumn(
                name: "Positionid",
                table: "Judges",
                newName: "Palataid");

            migrationBuilder.RenameIndex(
                name: "IX_Judges_Positionid",
                table: "Judges",
                newName: "IX_Judges_Palataid");

            migrationBuilder.AddForeignKey(
                name: "FK_Judges_Palats_Palataid",
                table: "Judges",
                column: "Palataid",
                principalTable: "Palats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
