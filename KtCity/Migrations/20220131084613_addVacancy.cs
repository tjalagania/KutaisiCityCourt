using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class addVacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Vacancyid",
                table: "AtachFiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtachFiles_Vacancyid",
                table: "AtachFiles",
                column: "Vacancyid");

            migrationBuilder.AddForeignKey(
                name: "FK_AtachFiles_Vacancies_Vacancyid",
                table: "AtachFiles",
                column: "Vacancyid",
                principalTable: "Vacancies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtachFiles_Vacancies_Vacancyid",
                table: "AtachFiles");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_AtachFiles_Vacancyid",
                table: "AtachFiles");

            migrationBuilder.DropColumn(
                name: "Vacancyid",
                table: "AtachFiles");
        }
    }
}
