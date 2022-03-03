using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _36thConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ProductGroup");

            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "BannerPath",
                table: "HomeBanner");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "ProductGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BannerImageId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BannerImageId",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 67);

            migrationBuilder.AddColumn<bool>(
                name: "ToWebp",
                table: "Media",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BannerId",
                table: "HomeBanner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroup_ImageId",
                table: "ProductGroup",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BannerImageId",
                table: "Product",
                column: "BannerImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_BannerImageId",
                table: "Post",
                column: "BannerImageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeBanner_BannerId",
                table: "HomeBanner",
                column: "BannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeBanner_Media_BannerId",
                table: "HomeBanner",
                column: "BannerId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Media_BannerImageId",
                table: "Post",
                column: "BannerImageId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Media_BannerImageId",
                table: "Product",
                column: "BannerImageId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroup_Media_ImageId",
                table: "ProductGroup",
                column: "ImageId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeBanner_Media_BannerId",
                table: "HomeBanner");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Media_BannerImageId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Media_BannerImageId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_Media_ImageId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_ImageId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_Product_BannerImageId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Post_BannerImageId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_HomeBanner_BannerId",
                table: "HomeBanner");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "ProductGroup");

            migrationBuilder.DropColumn(
                name: "BannerImageId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BannerImageId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "ToWebp",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "HomeBanner");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ProductGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerPath",
                table: "HomeBanner",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
