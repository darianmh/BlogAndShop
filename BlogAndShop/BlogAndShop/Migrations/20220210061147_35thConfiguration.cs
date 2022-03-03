using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _35thConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Brand");

            migrationBuilder.AddColumn<int>(
                name: "LogoId",
                table: "Brand",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_LogoId",
                table: "Brand",
                column: "LogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Media_LogoId",
                table: "Brand",
                column: "LogoId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Media_LogoId",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_LogoId",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "LogoId",
                table: "Brand");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
