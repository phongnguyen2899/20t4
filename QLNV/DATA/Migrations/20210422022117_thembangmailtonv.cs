using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class thembangmailtonv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mailtonhanviens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tieude = table.Column<string>(nullable: true),
                    Noidung = table.Column<string>(nullable: true),
                    NhanvienId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mailtonhanviens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mailtonhanviens_Nhanviens_NhanvienId",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanviens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mailtonhanviens_NhanvienId",
                table: "Mailtonhanviens",
                column: "NhanvienId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mailtonhanviens");
        }
    }
}
