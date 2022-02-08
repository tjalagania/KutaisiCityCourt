using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class RepNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostedDate",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostedDate",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Newsid",
                table: "AtachFiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AtachFiles_Newsid",
                table: "AtachFiles",
                column: "Newsid");

            migrationBuilder.AddForeignKey(
                name: "FK_AtachFiles_News_Newsid",
                table: "AtachFiles",
                column: "Newsid",
                principalTable: "News",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtachFiles_News_Newsid",
                table: "AtachFiles");

            migrationBuilder.DropIndex(
                name: "IX_AtachFiles_Newsid",
                table: "AtachFiles");

            migrationBuilder.DropColumn(
                name: "Newsid",
                table: "AtachFiles");

            migrationBuilder.AlterColumn<string>(
                name: "PostedDate",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostedDate",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
