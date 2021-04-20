using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class adddiembaitest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Diembaitest",
                table: "Nhanviens",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diembaitest",
                table: "Nhanviens");
        }
    }
}
