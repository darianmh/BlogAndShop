using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _25thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnamadLogo",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamandehiLogo",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnamadLogo",
                table: "SiteConfig");

            migrationBuilder.DropColumn(
                name: "SamandehiLogo",
                table: "SiteConfig");
        }
    }
}
