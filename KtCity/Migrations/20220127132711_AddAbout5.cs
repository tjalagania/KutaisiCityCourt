using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class AddAbout5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aboutid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.id);
                    table.ForeignKey(
                        name: "FK_Email_About_Aboutid",
                        column: x => x.Aboutid,
                        principalTable: "About",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Email_Aboutid",
                table: "Email",
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

            migrationBuilder.DropTable(
                name: "Email");

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
    }
}
