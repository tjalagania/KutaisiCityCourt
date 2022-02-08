using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class AddAbout2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aboutid",
                table: "AboutAtachFiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AboutAtachFiles_Aboutid",
                table: "AboutAtachFiles",
                column: "Aboutid");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutAtachFiles_About_Aboutid",
                table: "AboutAtachFiles",
                column: "Aboutid",
                principalTable: "About",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutAtachFiles_About_Aboutid",
                table: "AboutAtachFiles");

            migrationBuilder.DropIndex(
                name: "IX_AboutAtachFiles_Aboutid",
                table: "AboutAtachFiles");

            migrationBuilder.DropColumn(
                name: "Aboutid",
                table: "AboutAtachFiles");
        }
    }
}
