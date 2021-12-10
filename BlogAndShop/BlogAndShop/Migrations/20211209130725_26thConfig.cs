using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _26thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnamadAddress",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductForumGroup",
                table: "SiteConfig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamandehiAddress",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnamadAddress",
                table: "SiteConfig");

            migrationBuilder.DropColumn(
                name: "ProductForumGroup",
                table: "SiteConfig");

            migrationBuilder.DropColumn(
                name: "SamandehiAddress",
                table: "SiteConfig");
        }
    }
}
