using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _39thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IconId",
                table: "LearningSiteConfig",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "LearningSiteConfig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "LearningSiteConfig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LearningSiteConfig_IconId",
                table: "LearningSiteConfig",
                column: "IconId");

            migrationBuilder.AddForeignKey(
                name: "FK_LearningSiteConfig_Media_IconId",
                table: "LearningSiteConfig",
                column: "IconId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LearningSiteConfig_Media_IconId",
                table: "LearningSiteConfig");

            migrationBuilder.DropIndex(
                name: "IX_LearningSiteConfig_IconId",
                table: "LearningSiteConfig");

            migrationBuilder.DropColumn(
                name: "IconId",
                table: "LearningSiteConfig");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "LearningSiteConfig");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "LearningSiteConfig");
        }
    }
}
