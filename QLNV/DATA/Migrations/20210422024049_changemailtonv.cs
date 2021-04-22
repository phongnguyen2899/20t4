using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class changemailtonv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mailtonhanviens",
                table: "Mailtonhanviens");

            migrationBuilder.DropIndex(
                name: "IX_Mailtonhanviens_NhanvienId",
                table: "Mailtonhanviens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Mailtonhanviens");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mailtonhanviens",
                table: "Mailtonhanviens",
                column: "NhanvienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mailtonhanviens",
                table: "Mailtonhanviens");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Mailtonhanviens",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mailtonhanviens",
                table: "Mailtonhanviens",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mailtonhanviens_NhanvienId",
                table: "Mailtonhanviens",
                column: "NhanvienId",
                unique: true);
        }
    }
}
