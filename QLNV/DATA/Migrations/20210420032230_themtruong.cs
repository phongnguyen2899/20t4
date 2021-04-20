using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class themtruong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiadiemPV",
                table: "Nhanviens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ghichu",
                table: "Nhanviens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Trangthailienhe",
                table: "Nhanviens",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiadiemPV",
                table: "Nhanviens");

            migrationBuilder.DropColumn(
                name: "Ghichu",
                table: "Nhanviens");

            migrationBuilder.DropColumn(
                name: "Trangthailienhe",
                table: "Nhanviens");
        }
    }
}
