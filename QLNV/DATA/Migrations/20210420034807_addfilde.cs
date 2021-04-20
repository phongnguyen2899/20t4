using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class addfilde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ThoigianPV",
                table: "Nhanviens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThoigianPV",
                table: "Nhanviens");
        }
    }
}
