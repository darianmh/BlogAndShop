using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _37thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "DownloadItem");

            migrationBuilder.DropColumn(
                name: "DownloadPath",
                table: "DownloadItem");

            migrationBuilder.AddColumn<int>(
                name: "BannerImageId",
                table: "DownloadItem",
                type: "int",
                nullable: false,
                defaultValue: 111);

            migrationBuilder.AddColumn<int>(
                name: "DownloadPathId",
                table: "DownloadItem",
                type: "int",
                nullable: false,
                defaultValue: 111);

            migrationBuilder.CreateIndex(
                name: "IX_DownloadItem_BannerImageId",
                table: "DownloadItem",
                column: "BannerImageId");

            migrationBuilder.CreateIndex(
                name: "IX_DownloadItem_DownloadPathId",
                table: "DownloadItem",
                column: "DownloadPathId");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadItem_Media_BannerImageId",
                table: "DownloadItem",
                column: "BannerImageId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadItem_Media_DownloadPathId",
                table: "DownloadItem",
                column: "DownloadPathId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadItem_Media_BannerImageId",
                table: "DownloadItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DownloadItem_Media_DownloadPathId",
                table: "DownloadItem");

            migrationBuilder.DropIndex(
                name: "IX_DownloadItem_BannerImageId",
                table: "DownloadItem");

            migrationBuilder.DropIndex(
                name: "IX_DownloadItem_DownloadPathId",
                table: "DownloadItem");

            migrationBuilder.DropColumn(
                name: "BannerImageId",
                table: "DownloadItem");

            migrationBuilder.DropColumn(
                name: "DownloadPathId",
                table: "DownloadItem");

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "DownloadItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DownloadPath",
                table: "DownloadItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
