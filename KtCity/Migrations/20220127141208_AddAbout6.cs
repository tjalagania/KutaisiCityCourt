using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class AddAbout6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_About_Aboutid",
                table: "Email");

            migrationBuilder.DropTable(
                name: "AboutRekvizites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "Emails");

            migrationBuilder.RenameIndex(
                name: "IX_Email_Aboutid",
                table: "Emails",
                newName: "IX_Emails_Aboutid");

            migrationBuilder.AddColumn<int>(
                name: "Linksid",
                table: "AboutAtachFiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutAtachFiles_Linksid",
                table: "AboutAtachFiles",
                column: "Linksid");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutAtachFiles_Links_Linksid",
                table: "AboutAtachFiles",
                column: "Linksid",
                principalTable: "Links",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_About_Aboutid",
                table: "Emails",
                column: "Aboutid",
                principalTable: "About",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutAtachFiles_Links_Linksid",
                table: "AboutAtachFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_About_Aboutid",
                table: "Emails");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropIndex(
                name: "IX_AboutAtachFiles_Linksid",
                table: "AboutAtachFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Linksid",
                table: "AboutAtachFiles");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_Aboutid",
                table: "Email",
                newName: "IX_Email_Aboutid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "id");

            migrationBuilder.CreateTable(
                name: "AboutRekvizites",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aboutid = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutRekvizites", x => x.id);
                    table.ForeignKey(
                        name: "FK_AboutRekvizites_About_Aboutid",
                        column: x => x.Aboutid,
                        principalTable: "About",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutRekvizites_Aboutid",
                table: "AboutRekvizites",
                column: "Aboutid");

            migrationBuilder.AddForeignKey(
                name: "FK_Email_About_Aboutid",
                table: "Email",
                column: "Aboutid",
                principalTable: "About",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
