using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _27thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductForumInfos",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ForumTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductForumInfos", x => new { x.ProductId, x.ForumTitleId });
                    table.ForeignKey(
                        name: "FK_ProductForumInfos_ForumTitle_ForumTitleId",
                        column: x => x.ForumTitleId,
                        principalTable: "ForumTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductForumInfos_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductForumInfos_ForumTitleId",
                table: "ProductForumInfos",
                column: "ForumTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductForumInfos");
        }
    }
}
