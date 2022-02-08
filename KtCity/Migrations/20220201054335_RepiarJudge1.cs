using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class RepiarJudge1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Judgeid",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_Judgeid",
                table: "Workers",
                column: "Judgeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Judges_Judgeid",
                table: "Workers",
                column: "Judgeid",
                principalTable: "Judges",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Judges_Judgeid",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_Judgeid",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Judgeid",
                table: "Workers");
        }
    }
}
