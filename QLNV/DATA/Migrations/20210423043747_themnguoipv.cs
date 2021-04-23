using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class themnguoipv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nguoiphongvan",
                table: "Nhanviens",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nguoiphongvan",
                table: "Nhanviens");
        }
    }
}
