﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace KtCity.Migrations
{
    public partial class RepairGalery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Galeries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Galeries");
        }
    }
}
