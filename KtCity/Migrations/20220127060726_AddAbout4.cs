using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class AddAbout4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutAtachFiles_About_Aboutid",
                table: "AboutAtachFiles");

            migrationBuilder.RenameColumn(
                name: "Aboutid",
                table: "AboutAtachFiles",
                newName: "Rekviziteid");

            migrationBuilder.RenameIndex(
                name: "IX_AboutAtachFiles_Aboutid",
                table: "AboutAtachFiles",
                newName: "IX_AboutAtachFiles_Rekviziteid");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutAtachFiles_AboutRekvizites_Rekviziteid",
                table: "AboutAtachFiles",
                column: "Rekviziteid",
                principalTable: "AboutRekvizites",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutAtachFiles_AboutRekvizites_Rekviziteid",
                table: "AboutAtachFiles");

            migrationBuilder.RenameColumn(
                name: "Rekviziteid",
                table: "AboutAtachFiles",
                newName: "Aboutid");

            migrationBuilder.RenameIndex(
                name: "IX_AboutAtachFiles_Rekviziteid",
                table: "AboutAtachFiles",
                newName: "IX_AboutAtachFiles_Aboutid");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutAtachFiles_About_Aboutid",
                table: "AboutAtachFiles",
                column: "Aboutid",
                principalTable: "About",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
