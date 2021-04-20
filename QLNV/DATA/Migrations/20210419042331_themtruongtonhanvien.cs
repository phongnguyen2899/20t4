using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class themtruongtonhanvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lydoloai",
                table: "Nhanviens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Trangthai",
                table: "Nhanviens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isApply",
                table: "Nhanviens",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lydoloai",
                table: "Nhanviens");

            migrationBuilder.DropColumn(
                name: "Trangthai",
                table: "Nhanviens");

            migrationBuilder.DropColumn(
                name: "isApply",
                table: "Nhanviens");
        }
    }
}
