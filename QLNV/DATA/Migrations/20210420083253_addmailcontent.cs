using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class addmailcontent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noidungmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tieude = table.Column<string>(nullable: true),
                    Noidung = table.Column<string>(nullable: true),
                    Loaimail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noidungmails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noidungmails");
        }
    }
}
